using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public sealed class TextAlignClass : CssClass
{
    public static readonly TextAlignClass Inherit = new("text-align-inherit");

    public static readonly TextAlignClass Left = new("text-left");
    public static readonly TextAlignClass Center = new("text-center");
    public static readonly TextAlignClass Right = new("text-right");
    public static readonly TextAlignClass Justify = new("text-justify");

    public static readonly TextAlignClass Start = new("text-start");
    public static readonly TextAlignClass End = new("text-end");

    private TextAlignClass(string type) : base(type)
    {
    }
}