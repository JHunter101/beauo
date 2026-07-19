namespace Beauo.Types.Style.Base;

public abstract class CssClass(string name)
{
    public string Name { get; } = name;

    public override string ToString() => Name;
}