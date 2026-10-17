using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Variables;

public sealed class BgColorVar : CssColor
{
    public static readonly BgColorVar Main = new("main-bg", "Main", FgColorVar.Main);
    public static readonly BgColorVar Contrast = new("main-fg", "Contrast", FgColorVar.Contrast);
    public static readonly BgColorVar AltMain = new("alt-bg", "Alternative Main", FgColorVar.AltMain);
    public static readonly BgColorVar AltContrast = new("alt-fg", "Alternative Contrast", FgColorVar.AltContrast);

    public static readonly BgColorVar Black = new("black", "Black", FgColorVar.White);
    public static readonly BgColorVar Dark = new("dark", "Dark", FgColorVar.White);
    public static readonly BgColorVar Light = new("light", "Light", FgColorVar.Dark);
    public static readonly BgColorVar White = new("white", "White", FgColorVar.Black);

    public static readonly BgColorVar Grey = new("grey", "Grey", FgColorVar.White);
    public static readonly BgColorVar GreyLight = new("grey-light", "Grey Light", FgColorVar.Dark);
    public static readonly BgColorVar GreyDark = new("grey-dark", "Grey Dark", FgColorVar.White);

    public static readonly BgColorVar Red = new("red", "Red", FgColorVar.White);
    public static readonly BgColorVar RedLight = new("red-light", "Red Light", FgColorVar.Dark);
    public static readonly BgColorVar RedDark = new("red-dark", "Red Dark", FgColorVar.White);

    public static readonly BgColorVar Orange = new("orange", "Orange", FgColorVar.White);
    public static readonly BgColorVar OrangeLight = new("orange-light", "Orange Light", FgColorVar.Dark);
    public static readonly BgColorVar OrangeDark = new("orange-dark", "Orange Dark", FgColorVar.White);

    public static readonly BgColorVar Yellow = new("yellow", "Yellow", FgColorVar.White);
    public static readonly BgColorVar YellowLight = new("yellow-light", "Yellow Light", FgColorVar.Dark);
    public static readonly BgColorVar YellowDark = new("yellow-dark", "Yellow Dark", FgColorVar.White);

    public static readonly BgColorVar Green = new("green", "Green", FgColorVar.White);
    public static readonly BgColorVar GreenLight = new("green-light", "Green Light", FgColorVar.Dark);
    public static readonly BgColorVar GreenDark = new("green-dark", "Green Dark", FgColorVar.White);

    public static readonly BgColorVar Cyan = new("cyan", "Cyan", FgColorVar.White);
    public static readonly BgColorVar CyanLight = new("cyan-light", "Cyan Light", FgColorVar.Dark);
    public static readonly BgColorVar CyanDark = new("cyan-dark", "Cyan Dark", FgColorVar.White);

    public static readonly BgColorVar Blue = new("blue", "Blue", FgColorVar.White);
    public static readonly BgColorVar BlueLight = new("blue-light", "Blue Light", FgColorVar.Dark);
    public static readonly BgColorVar BlueDark = new("blue-dark", "Blue Dark", FgColorVar.White);

    public static readonly BgColorVar Purple = new("purple", "Purple", FgColorVar.White);
    public static readonly BgColorVar PurpleLight = new("purple-light", "Purple Light", FgColorVar.Dark);
    public static readonly BgColorVar PurpleDark = new("purple-dark", "Purple Dark", FgColorVar.White);

    public static readonly BgColorVar Pink = new("pink", "Pink", FgColorVar.White);
    public static readonly BgColorVar PinkLight = new("pink-light", "Pink Light", FgColorVar.Dark);
    public static readonly BgColorVar PinkDark = new("pink-dark", "Pink Dark", FgColorVar.White);

    public override string AsClass => $"bg-color-{Name}";

    public FgColorVar Accent { get; }

    private BgColorVar(string type, string displayText, FgColorVar accent) : base(type, displayText) => Accent = accent;
}