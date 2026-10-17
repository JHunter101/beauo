using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public sealed class JustifyContentClass : CssClass
{
    public static readonly JustifyContentClass Center = new("justify-center");
    public static readonly JustifyContentClass Start = new("justify-start");
    public static readonly JustifyContentClass End = new("justify-end");
    public static readonly JustifyContentClass SpaceAround = new("justify-around");
    public static readonly JustifyContentClass SpaceBetween = new("justify-between");
    public static readonly JustifyContentClass SpaceEvenly = new("justify-evenly");

    private JustifyContentClass(string classname) : base(classname)
    {
    }
}