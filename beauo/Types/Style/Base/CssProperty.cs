namespace Beauo.Types.Style.Base;

public sealed class CssProperty : Enumeration
{
    public string Name { get; }

    public static readonly CssProperty GridTemplateColumns = new("grid-template-columns", "Grid Template Columns");
    public static readonly CssProperty Width = new("width", "Width");
    public static readonly CssProperty Height = new("height", "Height");
    public static readonly CssProperty BackgroundColor = new("background-color", "Background Color");
    public static readonly CssProperty Color = new("color", "Color");

    private CssProperty(string name, string displayText) : base(displayText) => Name = name;

    public string AsProperty => $"--{Name}";
}