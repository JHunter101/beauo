using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public sealed class AlignItemsClass : CssClass
{
    public static readonly AlignItemsClass Center = new("align-center", "Center");
    public static readonly AlignItemsClass Start = new("align-start", "Start");
    public static readonly AlignItemsClass End = new("align-end", "End");
    public static readonly AlignItemsClass Stretch = new("align-stretch", "Stretch");

    private AlignItemsClass(string classname, string displayText) : base(classname, displayText)
    {
    }
}