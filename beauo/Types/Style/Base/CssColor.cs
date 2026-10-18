namespace Beauo.Types.Style.Base;

public abstract class CssColor(string name) : CssVariable(name, "rgb")
{
    public string AsRgbValue(int a = 1) => $"rgba({AsValue}, {a})";
}