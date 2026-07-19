using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public class JustifyContentClass : CssClass
{
    public static readonly JustifyContentClass Center = new("justify-center");
    public static readonly JustifyContentClass Start = new("justify-start");
    public static readonly JustifyContentClass End = new("justify-end");
    public static readonly JustifyContentClass SpaceAround = new("space-around");
    public static readonly JustifyContentClass SpaceBetween = new("space-between");
    public static readonly JustifyContentClass SpaceEvenly = new("space-evenly");

    private JustifyContentClass(string type) : base(type)
    {
    }
}