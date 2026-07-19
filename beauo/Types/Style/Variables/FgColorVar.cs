using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Variables;

public sealed class FgColorVar : CssColor
{
    public static readonly FgColorVar Main = new("main-fg");
    public static readonly FgColorVar Contrast = new("main-bg");
    public static readonly FgColorVar AltMain = new("alt-fg");
    public static readonly FgColorVar AltContrast = new("alt-bg");

    public static readonly FgColorVar Black = new("black");
    public static readonly FgColorVar Dark = new("dark");
    public static readonly FgColorVar Light = new("light");
    public static readonly FgColorVar White = new("white");

    public static readonly FgColorVar Grey = new("grey");
    public static readonly FgColorVar GreyLight = new("grey-light");
    public static readonly FgColorVar GreyDark = new("grey-dark");

    public static readonly FgColorVar Red = new("red");
    public static readonly FgColorVar RedLight = new("red-light");
    public static readonly FgColorVar RedDark = new("red-dark");

    public static readonly FgColorVar Orange = new("orange");
    public static readonly FgColorVar OrangeLight = new("orange-light");
    public static readonly FgColorVar OrangeDark = new("orange-dark");

    public static readonly FgColorVar Yellow = new("yellow");
    public static readonly FgColorVar YellowLight = new("yellow-light");
    public static readonly FgColorVar YellowDark = new("yellow-dark");

    public static readonly FgColorVar Green = new("green");
    public static readonly FgColorVar GreenLight = new("green-light");
    public static readonly FgColorVar GreenDark = new("green-dark");

    public static readonly FgColorVar Cyan = new("cyan");
    public static readonly FgColorVar CyanLight = new("cyan-light");
    public static readonly FgColorVar CyanDark = new("cyan-dark");

    public static readonly FgColorVar Blue = new("blue");
    public static readonly FgColorVar BlueLight = new("blue-light");
    public static readonly FgColorVar BlueDark = new("blue-dark");

    public static readonly FgColorVar Purple = new("purple");
    public static readonly FgColorVar PurpleLight = new("purple-light");
    public static readonly FgColorVar PurpleDark = new("purple-dark");

    public static readonly FgColorVar Pink = new("pink");
    public static readonly FgColorVar PinkLight = new("pink-light");
    public static readonly FgColorVar PinkDark = new("pink-dark");

    public override string AsClass => $"fg-color-{Name}";

    public string AsRGBA(int a = 1) => $"rgba({AsValue}, {a})";

    private FgColorVar(string type) : base(type)
    {
    }
}