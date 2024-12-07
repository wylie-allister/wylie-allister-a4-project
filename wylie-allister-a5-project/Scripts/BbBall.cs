using Godot;
using System;

public partial class BbBall : RigidBody2D
{
	[Export]
	int ballValue = 1;

	int[] batBall = { 1, 2, 3, 4, 5 };
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        int randomBat = batBall[GD.Randi() % batBall.Length];
        if (this.ballValue == randomBat)
		{

		}
	}
}
