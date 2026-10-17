namespace Beauo.Types.Style.Base;

public abstract class CssVariable(string value, string prefix, string displayText) : Enumeration(displayText)
{
    public string Name { get; } = value;
    public string AsValue { get; } = $"var(--{prefix}-{value})";
    public virtual string AsClass { get; } = $"{prefix}-{value}";
}