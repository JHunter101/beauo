using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public sealed class TextSizeClass : CssClass
{
    public static readonly TextSizeClass Inherit = new("text-size-inherit");
    public static readonly TextSizeClass Tiny = new("text-tiny");
    public static readonly TextSizeClass Small = new("text-small");
    public static readonly TextSizeClass Medium = new("text-medium");
    public static readonly TextSizeClass Large = new("text-large");
    public static readonly TextSizeClass Huge = new("text-huge");
    public static readonly TextSizeClass Billboard = new("text-billboard");

    private TextSizeClass(string type) : base(type)
    {
    }
}