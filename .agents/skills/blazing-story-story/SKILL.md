---
allowed-tools: Glob Grep Read Write
compatibility: Designed for Blazing Story projects (a Blazor-based Storybook clone for .NET). Requires a .Stories project referencing BlazingStory NuGet packages.
description: Implement a Blazing Story story file (.stories.razor) for a Blazor UI component. Use when the user says "create a story for component X", "add stories for X", or similar requests in a Blazing Story (.NET / Blazor / Storybook) project.
license: Unlicense
metadata:
    author: jsakamoto
    github-path: skills/blazing-story-story
    github-ref: refs/tags/v1.0.5
    github-repo: https://github.com/BlazingStory/agent-skills
    github-tree-sha: a8835f5598037e3a0ce7b451c5259543e7625f50
name: blazing-story-story
---
# Blazing Story — Story Implementation

Create a `.stories.razor` file for a Blazor component in the currently open Blazing Story project.

## Investigation policy

The main goal of this policy is to free the developer from the hassle of approving "may I run this command?" prompts one by one. Many of those prompts come from operations that poke around outside the project — and most of the knowledge needed to write a story file is already available without them.

Implement the story relying primarily on:

- The guidance in this skill file
- Your own knowledge of C#, .NET, Blazor, and general web/UI development
- Other relevant skills available in this environment
- Already-configured MCP servers and tools
- Read-only exploration of the current project (`ls`, `Glob`, `Grep`, `Read`)

**Avoid** operations that inspect the NuGet package cache folder, decompile Blazing Story DLLs, or otherwise probe the installed package contents. These are slow, require the developer's per-command approval, and disrupt the flow of work.

If implementation details that are not covered above become necessary, consult the published source code on GitHub at https://github.com/jsakamoto/BlazingStory **instead of** digging into the local NuGet cache or decompiling DLLs.

This policy may be relaxed only when strictly unavoidable.

## Step 1: Identify the target component

From `$ARGUMENTS` or the user's message, determine the component name (e.g., `Button`, `Rating`).

## Step 2: Locate the component file

Search the workspace for a `.razor` file matching the component name (e.g., `Button.razor`). Read it to understand:

- All `[Parameter]` properties and their types
- Any `RenderFragment` parameters (e.g., `ChildContent`)
- Enum types used by parameters

## Step 3: Locate the stories project

Find the stories project directory — it is typically a separate project named `*.Stories` or containing a `Stories/` subfolder. Look for existing `.stories.razor` files to confirm the correct location and the `@using` conventions used.

## Step 4: Determine the story file path

Place the new file inside the `Stories/` folder of the stories project, mirroring the category structure if one already exists. Name the file `ComponentName.stories.razor`.

Example: `MyApp.Stories/Stories/Components/Button.stories.razor`

## Step 5: Write the story file

Use the following structure:

```razor
@attribute [Stories("Category/ComponentName")]

@* Add @using directives only for namespaces not already imported via _Imports.razor *@

<Stories TComponent="ComponentName" Layout="typeof(CenteredLayout)">

    @* Place all <ArgType> elements first, then the <Story> elements. *@
    <ArgType For="_ => _.EnumParam" Control="ControlType.Radio" />
    <ArgType For="_ => _.ColorParam" Control="ControlType.Color" />

    <Story Name="Default">
        <Arguments>
            <Arg For="_ => _.SomeParam" Value="someValue" />
            @* Only when the component has a RenderFragment parameter — reference a @code field: *@
            <Arg For="_ => _.ChildContent" Value="_content" />
        </Arguments>
        <Template>
            <ComponentName @attributes="context.Args" />
        </Template>
    </Story>

</Stories>

@code {
    // Define RenderFragment values here only when the component has RenderFragment parameters.
    private RenderFragment _content = @<text>Label</text>;
}
```

### Rules

**File naming**
- Must end in `.stories.razor` to enable the "Show code" feature in Blazing Story.

**`[Stories("...")]` path**
- Use `/` as separator. The path becomes the sidebar navigation tree.
- Mirror the folder path under `Stories/` (e.g., file at `Stories/Components/Button.stories.razor` → `[Stories("Components/Button")]`).

**`<Stories TComponent="...">`**
- `TComponent` is the Blazor component type.
- `Layout` is optional. Since v1.0.0-preview.81, Blazing Story ships three built-in presets in the `BlazingStory.Components.Layouts` namespace:
  - `CenteredLayout` — centers the component horizontally and vertically; good default for buttons, badges, icons, and compact UI elements.
  - `FullFrameLayout` — expands to fill the preview frame while retaining margins; good for panels, cards, and layout-sensitive containers.
  - `NoMarginLayout` — removes all margins so content extends edge-to-edge; good for full-bleed page shells or components that control their own spacing.
  - Omit `Layout` entirely if you are unsure or if no layout is needed.
- These presets can also be applied at the `<Story>` level for a single variant. Layouts at different levels do **not** override each other — they **nest**: the app-level layout wraps outermost, the `<Stories>`-level layout wraps inside it, and the `<Story>`-level layout wraps the innermost layer.
- Check whether `BlazingStory.Components.Layouts` is already imported via `_Imports.razor`; if not, add `@using BlazingStory.Components.Layouts` at the top of the story file.

**Custom layouts**
- If the built-in presets don't meet your needs, create a component that `@inherits LayoutComponentBase` and renders `@Body`.
- The following CSS custom properties and HTML attributes are available inside the preview frame and are useful when styling a custom layout:

  | Name | Where | Description |
  |---|---|---|
  | `--bs-preview-body-margin` | CSS custom property on `<body>` | Controls the body margin. Undefined by default; built-in layouts use `var(--bs-preview-body-margin, 16px)`. Set to `0px` to remove the margin entirely. |
  | `--bs-zoom` | CSS custom property on `<body>` | Current zoom level of the preview frame. Always reference with a fallback: `var(--bs-zoom, 1)`. |
  | `data-bs-parent-frame` | HTML attribute on `<body>` | Frame context: `"docs"` when embedded in a Docs page, `"story"` when displayed as a standalone Story page. |

- For complete implementation examples, see the built-in layout components: [BlazingStory/Components/Layouts](https://github.com/jsakamoto/BlazingStory/tree/main/BlazingStory/Components/Layouts)

**`<ArgType>`**
- Controls how a parameter appears in the Controls panel.
- Available `ControlType` values:
  - `ControlType.Default` — auto-detected from the parameter type (no need to specify explicitly).
  - `ControlType.Radio` — radio buttons; good for enums with 2–4 values.
  - `ControlType.Select` — dropdown; good for enums with 5+ values.
  - `ControlType.Color` — color picker; use for `string` or `Color` parameters representing a color.

**Custom parameter controllers (since v1.0.0-preview.87)**
- When none of the built-in `ControlType` options fit a parameter, supply your own component as the Controls-panel editor by placing it as the child content of `<ArgType>`:
  ```razor
  <ArgType For="_ => _.TestEnum">
      <MyCustomController />
  </ArgType>
  ```
  When `<ArgType>` has child content, the custom controller renders in place of the default control; `Control="..."` is ignored for that parameter.
- A custom controller component must derive from `ParameterControllerBase` (in the `BlazingStory.Addons.BuiltIns.Panel.Controls.ParameterControllers.Controllers` namespace, shipped in the `BlazingStory.Addons.BuiltIns` assembly):
  ```razor
  @using BlazingStory.Addons.BuiltIns.Panel.Controls.ParameterControllers.Controllers
  @inherits ParameterControllerBase

  @* render the editing UI for the current parameter here *@

  @code {
      // Read the current parameter value:
      private MyEnum GetValue()
          => this.Context.Value == null ? MyEnum.None : (MyEnum)this.Context.Value;

      // Write a new value back through the Controls panel:
      private async Task OnChange(MyEnum newValue)
      {
          await this.OnInputAsync(newValue);
      }
  }
  ```
- Inheriting from `ParameterControllerBase` gives the component two things:
  - `this.Context` — a `ParameterControllerContext` exposing the bound parameter. Members:

    | Member | Type | Description |
    |---|---|---|
    | `Context.Value` | `object?` | The current parameter value. Cast it to the parameter's type to read it (it may be `null`). |
    | `Context.Key` | `string` | Unique key identifying this controller instance. |
    | `Context.Parameter` | `IComponentParameter` | Metadata about the bound parameter. |
    | `Context.OnInput` | `EventCallback<ParameterInputEventArgs>` | The underlying input callback; normally you call `OnInputAsync` instead. |

  - `this.OnInputAsync(object? value)` — call this to push a UI-entered value back into the parameter so the previewed component updates.
- The controller's lifecycle behaves like any Blazor component, so use `OnInitialized`/`OnParametersSet` for setup (e.g. enumerating enum names) and read `this.Context` from there onward.
- Useful when the parameter needs richer editing than a single control — for example a `[Flags]` enum rendered as a group of checkboxes, where each toggle sets/clears a bit and calls `OnInputAsync` with the combined value.

**`<Story Name="...">`**
- Each `<Story>` represents one variant shown in the sidebar.
- Always include a `"Default"` story as the baseline.
- Add further stories for meaningful parameter combinations (e.g., `"Large"`, `"Disabled"`, `"With Icon"`).

**`<Arguments>` and `<Arg>`**
- Use `<Arg For="_ => _.ParamName" Value="..." />` to set initial parameter values for a story.
- For `RenderFragment` parameters, define the value in the `@code` block and reference it via `<Arg>`:
  ```razor
  <Arg For="_ => _.ChildContent" Value="_content" />

  @code {
      private RenderFragment _content = @<text>Click me</text>;
  }
  ```
- Do **not** hardcode `RenderFragment` content directly in the `<Template>` markup — this prevents runtime modification via the Controls panel.

**`<Template>`**
- Always add `@attributes="context.Args"` to the component tag to wire up the Controls panel.
- Pass only parameters that cannot be handled via `@attributes` (e.g., event callbacks, non-parameter child content) directly in the markup.

**Null-forgiving operator**
- When the component type is nullable, use `_=>_!.PropertyName` in `For` lambdas:
  ```razor
  <ArgType For="_=>_!.Color" Control="ControlType.Color" />
  ```

**`@using` directives**
- Check whether the component namespace is already imported globally (e.g., via `_Imports.razor`). Add `@using` only if needed.

## Step 6: Verify

After writing the file, briefly summarize:
- The file path created
- The stories added and which parameter variants they cover
- Any `ArgType` customizations applied
- Any assumptions made (e.g., chosen `Layout`, omitted optional parameters)
