using Godot;
using System;

public partial class MergeArea : Area2D
{
	[Export]
    private RigidBody2D Ball;

	[Export]
	public PackedScene MergeBall;

	private void OnBodyEntered(Node2D body)
	{
		//Destroys ball (trying to add ball spawning in the place of it but man, godot is way harder than i thought so I'm sorry if it doesn't get added, I tried :( )
		Ball.QueueFree();
		GD.Print($"Destroy {Ball.Name}");
	}
}
