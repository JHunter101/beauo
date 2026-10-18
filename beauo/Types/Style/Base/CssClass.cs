namespace Beauo.Types.Style.Base;

public abstract class CssClass(string className) : Enumeration(className)
{
    private readonly string _name = className;

    public override string ToString() => _name;
}