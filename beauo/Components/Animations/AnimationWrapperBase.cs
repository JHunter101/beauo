using Microsoft.AspNetCore.Components;

namespace Beauo.Components.Animations;

public abstract class AnimationWrapperBase : ComponentBase, IDisposable
{
    [Parameter] public EventCallback OnAnimationComplete { get; set; }
    [Parameter, EditorRequired] public int AnimationToken { get; set; }
    [Parameter] public TimeSpan Duration { get; set; } = TimeSpan.FromMilliseconds(500);
    [Parameter] public TimeSpan Stagger { get; set; } = TimeSpan.Zero;
    [Parameter] public int Index { get; set; }
    [Parameter] public bool IsTarget { get; set; } = true;
    [Parameter, EditorRequired] public RenderFragment? ChildContent { get; set; }

    protected abstract string AnimationName { get; }

    protected bool IsAnimating { get; set; }

    protected string WrapperStyle =>
        $"--{AnimationName}-duration: {Duration.TotalMilliseconds}ms; " +
        $"--{AnimationName}-stagger-delay: {Index * Stagger.TotalMilliseconds}ms;";

    protected string CssClass => IsAnimating ? "active" : "";

    private int _lastToken;
    private bool _disposed;

    protected override void OnParametersSet()
    {
        if (!IsTarget || AnimationToken == _lastToken || IsAnimating)
        {
            return;
        }

        _ = StartAnimationAsync();
    }

    private async Task StartAnimationAsync()
    {
        if (_disposed || IsAnimating)
        {
            return;
        }

        _lastToken = AnimationToken;

        IsAnimating = true;
        StateHasChanged();

        await Task.Delay(Duration + TimeSpan.FromMilliseconds((Index * Stagger.TotalMilliseconds) + 200));

        if (_disposed)
        {
            return;
        }

        IsAnimating = false;
        StateHasChanged();

        if (OnAnimationComplete.HasDelegate)
        {
            await OnAnimationComplete.InvokeAsync(Index);
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }
        _disposed = true;
    }
}