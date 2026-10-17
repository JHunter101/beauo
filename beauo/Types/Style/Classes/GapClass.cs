using Beauo.Types.Style.Base;
using Beauo.Types.Style.Variables;

namespace Beauo.Types.Style.Classes;

public sealed class GapClass : CssClass
{
    public static readonly GapClass Tiny = new(SizeVar.Size4, "Tiny");
    public static readonly GapClass Small = new(SizeVar.Size8, "Small");
    public static readonly GapClass Medium = new(SizeVar.Size12, "Medium");
    public static readonly GapClass Large = new(SizeVar.Size24, "Large");
    public static readonly GapClass Huge = new(SizeVar.Size48, "Huge");

    private GapClass(SizeVar size, string displayText) : base($"gap-{size.Name}", displayText)
    {
    }
}