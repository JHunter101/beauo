using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bunit;
using Shouldly;
using Microsoft.AspNetCore.Components.Web;

namespace beauo.Tests;

[TestClass]
public class ComponentInteractionTests
{
    private Bunit.TestContext ctx = null!;

    [TestInitialize]
    public void Setup() => ctx = new Bunit.TestContext();

    [TestCleanup]
    public void Cleanup() => ctx.Dispose();

    [TestMethod]
    public void Button_OnClick_InvokesCallback()
    {
        var clicked = false;

        var cut = ctx.RenderComponent<Beauo.Components.Button>(parameters => parameters
            .Add(p => p.Text, "Click Me")
            .Add(p => p.OnClick, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MouseEventArgs>(this, (MouseEventArgs _) => clicked = true))
        );

        cut.Find("button").Click();
        clicked.ShouldBeTrue();
    }

    [TestMethod]
    public void Checkbox_Toggle_InvokesCallback()
    {
        var state = false;

        var cut = ctx.RenderComponent<Beauo.Components.Settings.Checkbox>(parameters => parameters
            .Add(p => p.Value, state)
            .Add(p => p.ValueChanged, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, (bool v) => state = v))
            .AddChildContent("Enable")
        );

        var input = cut.Find("input[type=checkbox]");
        input.Change(true);
        state.ShouldBeTrue();
    }
}
