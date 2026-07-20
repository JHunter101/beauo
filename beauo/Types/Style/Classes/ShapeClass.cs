using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public sealed class ShapeClass : CssClass
{
    public static readonly ShapeClass Tag = new("tag");

    private ShapeClass(string type) : base(type)
    {
    }
}