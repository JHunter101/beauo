using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Variables;

public sealed class FgColorVar : CssColor
{
    public static readonly FgColorVar Main = new("main-fg", "Main");
    public static readonly FgColorVar Contrast = new("main-bg", "Contrast");
    public static readonly FgColorVar AltMain = new("alt-fg", "Alternative Main");
    public static readonly FgColorVar AltContrast = new("alt-bg", "Alternative Contrast");

    public static readonly FgColorVar Black = new("black", "Black");
    public static readonly FgColorVar Dark = new("dark", "Dark");
    public static readonly FgColorVar Light = new("light", "Light");
    public static readonly FgColorVar White = new("white", "White");

    public static readonly FgColorVar Grey = new("grey", "Grey");
    public static readonly FgColorVar GreyLight = new("grey-light", "Grey Light");
    public static readonly FgColorVar GreyDark = new("grey-dark", "Grey Dark");

    public static readonly FgColorVar Red = new("red", "Red");
    public static readonly FgColorVar RedLight = new("red-light", "Red Light");
    public static readonly FgColorVar RedDark = new("red-dark", "Red Dark");

    public static readonly FgColorVar Orange = new("orange", "Orange");
    public static readonly FgColorVar OrangeLight = new("orange-light", "Orange Light");
    public static readonly FgColorVar OrangeDark = new("orange-dark", "Orange Dark");

    public static readonly FgColorVar Yellow = new("yellow", "Yellow");
    public static readonly FgColorVar YellowLight = new("yellow-light", "Yellow Light");
    public static readonly FgColorVar YellowDark = new("yellow-dark", "Yellow Dark");

    public static readonly FgColorVar Green = new("green", "Green");
    public static readonly FgColorVar GreenLight = new("green-light", "Green Light");
    public static readonly FgColorVar GreenDark = new("green-dark", "Green Dark");

    public static readonly FgColorVar Cyan = new("cyan", "Cyan");
    public static readonly FgColorVar CyanLight = new("cyan-light", "Cyan Light");
    public static readonly FgColorVar CyanDark = new("cyan-dark", "Cyan Dark");

    public static readonly FgColorVar Blue = new("blue", "Blue");
    public static readonly FgColorVar BlueLight = new("blue-light", "Blue Light");
    public static readonly FgColorVar BlueDark = new("blue-dark", "Blue Dark");

    public static readonly FgColorVar Purple = new("purple", "Purple");
    public static readonly FgColorVar PurpleLight = new("purple-light", "Purple Light");
    public static readonly FgColorVar PurpleDark = new("purple-dark", "Purple Dark");

    public static readonly FgColorVar Pink = new("pink", "Pink");
    public static readonly FgColorVar PinkLight = new("pink-light", "Pink Light");
    public static readonly FgColorVar PinkDark = new("pink-dark", "Pink Dark");

    public override string AsClass => $"fg-color-{Name}";

    public string AsRGBA(int a = 1) => $"rgba({AsValue}, {a})";

    private FgColorVar(string type, string displayText) : base(type, displayText)
    {
    }
}