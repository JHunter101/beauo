using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Variables;

public sealed class BgColorVar : CssColor
{
    public static readonly BgColorVar Main = new("main-bg", FgColorVar.Main);
    public static readonly BgColorVar Contrast = new("main-fg", FgColorVar.Contrast);
    public static readonly BgColorVar AltMain = new("alt-bg", FgColorVar.AltMain);
    public static readonly BgColorVar AltContrast = new("alt-fg", FgColorVar.AltContrast);

    public static readonly BgColorVar Black = new("black", FgColorVar.White);
    public static readonly BgColorVar Dark = new("dark", FgColorVar.White);
    public static readonly BgColorVar Light = new("light", FgColorVar.Dark);
    public static readonly BgColorVar White = new("white", FgColorVar.Black);

    public static readonly BgColorVar Grey = new("grey", FgColorVar.White);
    public static readonly BgColorVar GreyLight = new("grey-light", FgColorVar.Dark);
    public static readonly BgColorVar GreyDark = new("grey-dark", FgColorVar.Light);

    public static readonly BgColorVar Red = new("red", FgColorVar.White);
    public static readonly BgColorVar RedLight = new("red-light", FgColorVar.Dark);
    public static readonly BgColorVar RedDark = new("red-dark", FgColorVar.Light);

    public static readonly BgColorVar Orange = new("orange", FgColorVar.White);
    public static readonly BgColorVar OrangeLight = new("orange-light", FgColorVar.Dark);
    public static readonly BgColorVar OrangeDark = new("orange-dark", FgColorVar.Light);

    public static readonly BgColorVar Yellow = new("yellow", FgColorVar.White);
    public static readonly BgColorVar YellowLight = new("yellow-light", FgColorVar.Dark);
    public static readonly BgColorVar YellowDark = new("yellow-dark", FgColorVar.Light);

    public static readonly BgColorVar Green = new("green", FgColorVar.White);
    public static readonly BgColorVar GreenLight = new("green-light", FgColorVar.Dark);
    public static readonly BgColorVar GreenDark = new("green-dark", FgColorVar.Light);

    public static readonly BgColorVar Cyan = new("cyan", FgColorVar.White);
    public static readonly BgColorVar CyanLight = new("cyan-light", FgColorVar.Dark);
    public static readonly BgColorVar CyanDark = new("cyan-dark", FgColorVar.Light);

    public static readonly BgColorVar Blue = new("blue", FgColorVar.White);
    public static readonly BgColorVar BlueLight = new("blue-light", FgColorVar.Dark);
    public static readonly BgColorVar BlueDark = new("blue-dark", FgColorVar.Light);

    public static readonly BgColorVar Purple = new("purple", FgColorVar.White);
    public static readonly BgColorVar PurpleLight = new("purple-light", FgColorVar.Dark);
    public static readonly BgColorVar PurpleDark = new("purple-dark", FgColorVar.Light);

    public static readonly BgColorVar Pink = new("pink", FgColorVar.White);
    public static readonly BgColorVar PinkLight = new("pink-light", FgColorVar.Dark);
    public static readonly BgColorVar PinkDark = new("pink-dark", FgColorVar.Light);

    public override string AsClass => $"bg-color-{Name}";

    public FgColorVar Accent { get; }

    private BgColorVar(string name, FgColorVar accent) : base(name) => Accent = accent;
}