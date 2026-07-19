using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public sealed class AlignItemsClass : CssClass
{
    public static readonly AlignItemsClass Center = new("align-center");
    public static readonly AlignItemsClass Start = new("align-start");
    public static readonly AlignItemsClass End = new("align-end");
    public static readonly AlignItemsClass Stretch = new("align-stretch");

    private AlignItemsClass(string type) : base(type)
    {
    }
}