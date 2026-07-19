namespace Beauo.Types.Style.Base;

public sealed class CssProperty
{
    public static CssProperty GridTemplateColumns { get; } = new("grid-template-columns");
    public static CssProperty Width { get; } = new("width");
    public static CssProperty Height { get; } = new("height");
    public static CssProperty BackgroundColor { get; } = new("background-color");
    public static CssProperty Color { get; } = new("color");

    private CssProperty(string name) => Name = name;

    public string Name { get; }
    public string AsProperty => $"--{Name}";

    public override string ToString()
    {
#if DEBUG
        Console.WriteLine($"WARNING: ToString() called on CssProperty '{Name}'. Use {nameof(Name)} property instead.");
#endif
        return Name;
    }
}