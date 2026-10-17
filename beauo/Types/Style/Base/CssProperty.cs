namespace Beauo.Types.Style.Base;

public sealed class CssProperty : Enumeration
{
    private readonly string _name;

    public override string ToString() => _name;

    public static readonly CssProperty GridTemplateColumns = new("grid-template-columns");
    public static readonly CssProperty Width = new("width");
    public static readonly CssProperty Height = new("height");
    public static readonly CssProperty BackgroundColor = new("background-color");
    public static readonly CssProperty Color = new("color");

    private CssProperty(string name) : base(name) => _name = name;
}