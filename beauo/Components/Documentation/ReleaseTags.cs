using Beauo.Types.Contents;
using Beauo.Types.Style.Variables;

namespace Beauo.Components.Documentation;

public static class ReleaseTag
{
    public static readonly ShapeContent Initial = new(BgColorVar.Blue, "Initial");
    public static readonly ShapeContent Technical = new(BgColorVar.Blue, "Technical");
    public static readonly ShapeContent Performance = new(BgColorVar.Blue, "Performance");

    public static readonly ShapeContent New = new(BgColorVar.Green, "New");

    public static readonly ShapeContent Overhaul = new(BgColorVar.Yellow, "Overhaul");
    public static readonly ShapeContent Patch = new(BgColorVar.Yellow, "Patch");

    public static readonly ShapeContent Balance = new(BgColorVar.Orange, "Balance");
    public static readonly ShapeContent Fix = new(BgColorVar.Orange, "Fix");

    public static readonly ShapeContent Breaking = new(BgColorVar.Red, "Breaking");
}