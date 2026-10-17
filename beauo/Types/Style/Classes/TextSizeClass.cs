using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public sealed class TextSizeClass : CssClass
{
    public static readonly TextSizeClass Inherit = new("text-size-inherit", "Inherit");
    public static readonly TextSizeClass Tiny = new("text-tiny", "Tiny");
    public static readonly TextSizeClass Small = new("text-small", "Small");
    public static readonly TextSizeClass Medium = new("text-medium", "Medium");
    public static readonly TextSizeClass Large = new("text-large", "Large");
    public static readonly TextSizeClass Huge = new("text-huge", "Huge");
    public static readonly TextSizeClass Billboard = new("text-billboard", "Billboard");

    private TextSizeClass(string classname, string displayText) : base(classname, displayText)
    {
    }
}