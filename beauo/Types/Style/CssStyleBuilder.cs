using Beauo.Types.Style.Base;

namespace Beauo.Types.Style;

public sealed class CssStyleBuilder
{
    private readonly List<string> _styles = [];

    public CssStyleBuilder AddStyle(CssProperty property, CssVariable? value)
        => Add(property, value?.AsValue);

    public CssStyleBuilder AddStyle(CssProperty property, string? value)
        => Add(property, value);

    private CssStyleBuilder Add(CssProperty property, string? value)
    {
        if (value is not null)
        {
            _styles.Add($"{property}: {value};");
        }

        return this;
    }

    public override string ToString() => string.Join(" ", _styles);
}