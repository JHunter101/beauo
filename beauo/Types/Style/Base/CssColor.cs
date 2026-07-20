namespace Beauo.Types.Style.Base;

public abstract class CssColor(string name) : CssVariable(name, "rgb")
{
    public abstract override string AsClass { get; }

    public string AsRgbValue(int a = 1) => $"rgba({base.AsValue}, {a})";
}