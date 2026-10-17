using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class StoriesExistenceTests
{
    [TestClass]
    public void AllPublicComponentsHaveStories()
    {
        var solutionRoot = Path.GetFullPath(Path.Combine("..", ""));
        var projectRoot = Path.Combine(solutionRoot, "beauo");
        var components = Directory.GetFiles(Path.Combine(projectRoot, "Components"), "*.razor", SearchOption.AllDirectories)
            .Select(p => Path.GetRelativePath(projectRoot, p).Replace('\', '/'))
            .Where(p => !p.Contains("/Internal/") && !p.Contains("\\Internal\\"))
            .ToList();

        var storiesRoot = Path.Combine(solutionRoot, "beauo.stories", "Stories");
        var stories = Directory.GetFiles(storiesRoot, "*.stories.razor", SearchOption.AllDirectories)
            .Select(p => Path.GetFileNameWithoutExtension(p).Replace(".stories", ""))
            .ToHashSet();

        var missing = components.Where(c =>
        {
            var file = Path.GetFileNameWithoutExtension(c);
            return !stories.Contains(file);
        }).ToList();

        missing.Count.ShouldBe(0, "Missing stories for components: " + string.Join(", ", missing));
    }
}
