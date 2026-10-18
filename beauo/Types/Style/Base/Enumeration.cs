using System.Reflection;

namespace Beauo.Types.Style.Base;

public abstract class Enumeration(string displayText)
{
    public string DisplayText { get; } = displayText;

    public override string ToString() => DisplayText;

    public static IEnumerable<T> GetAll<T>() where T : Enumeration
    {
        Type type = typeof(T);
        return [.. type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(f => type.IsAssignableFrom(f.FieldType))
            .Select(f => (T)f.GetValue(null)!)];
    }
}