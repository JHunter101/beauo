using Beauo.Types.Style.Base;

namespace Beauo.Types.Style.Variables;

public sealed class SizeVar : CssVariable
{
    public static readonly SizeVar Size2 = new("2x", "2x");
    public static readonly SizeVar Size4 = new("4x", "4x");
    public static readonly SizeVar Size8 = new("8x", "8x");
    public static readonly SizeVar Size12 = new("12x", "12x");
    public static readonly SizeVar Size16 = new("16x", "16x");
    public static readonly SizeVar Size24 = new("24x", "24x");
    public static readonly SizeVar Size32 = new("32x", "32x");
    public static readonly SizeVar Size48 = new("48x", "48x");
    public static readonly SizeVar Size64 = new("64x", "64x");
    public static readonly SizeVar Size80 = new("80x", "80x");
    public static readonly SizeVar Size96 = new("96x", "96x");
    public static readonly SizeVar Size128 = new("128x", "128x");

    private SizeVar(string type, string displayText) : base(type, displayText, "size")
    {
    }
}