using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public sealed class TextAlignClass : CssClass
{
    public static readonly TextAlignClass Inherit = new("text-align-inherit", "Inherit");

    public static readonly TextAlignClass Left = new("text-left", "Left");
    public static readonly TextAlignClass Center = new("text-center", "Center");
    public static readonly TextAlignClass Right = new("text-right", "Right");
    public static readonly TextAlignClass Justify = new("text-justify", "Justify");

    public static readonly TextAlignClass Start = new("text-start", "Start");
    public static readonly TextAlignClass End = new("text-end", "End");

    private TextAlignClass(string classname, string displayText) : base(classname, displayText)
    {
    }
}