using Beauo.Types.Style.Base;
using Beauo.Types.Style.Variables;

namespace Beauo.Types.Style.Classes;

public sealed class GapClass : CssClass
{
    public static readonly GapClass Tiny = new(SizeVar.Size4);
    public static readonly GapClass Small = new(SizeVar.Size8);
    public static readonly GapClass Medium = new(SizeVar.Size12);
    public static readonly GapClass Large = new(SizeVar.Size24);
    public static readonly GapClass Huge = new(SizeVar.Size48);

    private GapClass(SizeVar size) : base($"gap-{size.Name}")
    {
    }
}