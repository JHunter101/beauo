using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Classes;

public class JustifyContentClass : CssClass
{
    public static readonly JustifyContentClass Center = new("justify-center", "Center");
    public static readonly JustifyContentClass Start = new("justify-start", "Start");
    public static readonly JustifyContentClass End = new("justify-end", "End");
    public static readonly JustifyContentClass SpaceAround = new("space-around", "Space Around");
    public static readonly JustifyContentClass SpaceBetween = new("space-between", "Space Between");
    public static readonly JustifyContentClass SpaceEvenly = new("space-evenly", "Space Evenly");

    private JustifyContentClass(string classname, string displayText) : base(classname, displayText)
    {
    }
}