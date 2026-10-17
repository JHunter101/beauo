namespace Beauo.Types.Style.Base;

public abstract class CssColor(string name, string displayText) : CssVariable(name, "rgb", displayText)
{
    public string AsRgbValue(int a = 1) => $"rgba({AsValue}, {a})";
}