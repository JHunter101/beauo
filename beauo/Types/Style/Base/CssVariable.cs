namespace Beauo.Types.Style.Base;

public abstract class CssVariable(string value, string prefix)
{
    public string Name { get; } = value;
    public string AsValue { get; } = $"var(--{prefix}-{value})";
    public virtual string AsClass { get; } = $"{prefix}-{value}";

    public override string ToString()
    {
#if DEBUG
        Console.WriteLine($"WARNING: ToString() called on CssVariable '{Name}' (type: {GetType().Name}). Use {nameof(Name)}, {nameof(AsValue)}, or {nameof(AsClass)} instead.");
#endif
        return Name;
    }
}