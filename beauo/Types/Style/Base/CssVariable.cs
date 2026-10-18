namespace Beauo.Types.Style.Base;

public abstract class CssVariable(string value, string prefix) : Enumeration(value)
{
    public string AsValue { get; } = $"var(--{prefix}-{value})";
    public virtual string AsClass { get; } = $"{prefix}-{value}";
}