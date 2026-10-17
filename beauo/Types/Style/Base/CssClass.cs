namespace Beauo.Types.Style.Base;

public abstract class CssClass(string className, string displayText) : Enumeration(displayText!)
{
    public string Name { get; } = className;
}