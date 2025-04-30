using Demo;
using Friflo.EcGui;
using Godot;
using ImGuiGodot;
using ImGuiNET;

namespace FrifloEcGuiGodot;

public partial class FrifloEcGui : Node2D
{
    public override void _Ready()
    {
        ImGuiGD.ToolInit();
        var io = ImGui.GetIO();
        io.ConfigFlags |=  ImGuiConfigFlags.DockingEnable | ImGuiConfigFlags.NavEnableKeyboard | ImGuiConfigFlags.NavEnableGamepad;
        
        // Optional: add custom TrueType font: Inter-Regular.ttf
        ImGuiGD.ResetFonts();
        ImGuiGD.AddFont(GD.Load<FontFile>("res://Inter-Regular.ttf"), 20);
        ImGuiGD.AddFontDefault();
        ImGuiGD.RebuildFontAtlas();
        
        ImGui.StyleColorsLight();           // optional
        EcGui.Setup.SetDefaultStyles();     // optional
        DemoECS.CreateEntityStore();
        DemoECS.CustomizeEcGui();
    }

    public override void _Process(double delta)
    {
        DemoECS.Update();
        EcGui.HistorySnapshot();     // optional - required to show histories
        EcGui.ExplorerWindow();
        EcGui.InspectorWindow();
    }
}