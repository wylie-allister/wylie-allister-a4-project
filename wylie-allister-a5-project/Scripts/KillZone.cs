using Godot;
using System;

public partial class KillZone : Node2D
{
    [Export]
    private PackedScene DeathScreen;

    private void OnTimerTimeout()
    {
        //loads death screen 
        var deathScreen = ResourceLoader.Load<PackedScene>("res://Scenes/DeathScreen.tscn").Instantiate();
        GetTree().Root.AddChild(deathScreen);
    }
}
