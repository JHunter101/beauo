using System.Reflection;

namespace Beauo.Types.Style.Base;

public abstract class Enumeration(string displayText)
{
    public string DisplayText { get; } = displayText;

    public override string ToString()
    {
#if DEBUG
        Console.WriteLine($"WARNING: ToString() called on CssVariable '{DisplayText}' (type: {GetType().Name}). Use one of the properties instead");
#endif
        return DisplayText;
    }

    public static IEnumerable<T> GetAll<T>() where T : Enumeration
    {
        var type = typeof(T);
        return [.. type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(f => type.IsAssignableFrom(f.FieldType))
            .Select(f => (T)f.GetValue(null)!)];
    }
}