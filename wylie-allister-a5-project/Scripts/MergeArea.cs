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
		Ball.QueueFree();
		GD.Print($"Destroy {Ball.Name}");
	}
}
