using Beauo.Types.Style.Base;

namespace Beauo.Types.Style;

public sealed class CssStyleBuilder
{
    private readonly List<string> _styles = [];

    public CssStyleBuilder AddVariable(CssProperty property, CssVariable? value) =>
        Add(property.AsProperty, value?.AsValue);

    public CssStyleBuilder AddVariable(CssProperty property, string? value) =>
        Add(property.AsProperty, value);

    public CssStyleBuilder AddStyle(CssProperty property, CssVariable? value) =>
        Add(property.Name, value?.AsValue);

    public CssStyleBuilder AddStyle(CssProperty property, string? value) =>
        Add(property.Name, value);

    private CssStyleBuilder Add(string property, string? value)
    {
        if (value is not null)
        {
            _styles.Add($"{property}: {value};");
        }

        return this;
    }

    public override string ToString() => string.Join(" ", _styles);
}