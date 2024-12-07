using Godot;
using System;

public partial class Dropper : Node2D
{
	float speed = 300;

	[Export]
	private PackedScene Prefab;

	[Export]
	private PackedScene Prefab2;
	
	[Export]
	private PackedScene Prefab3;

	[Export]
	private PackedScene Prefab4;
	
	[Export]
	private PackedScene Prefab5;

	[Export]
	private Node2D BallParent;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float moveX = Input.GetAxis("left", "right") * speed * (float)delta;
		Translate(new Vector2 (moveX, 0));


        if (Input.IsActionJustPressed("drop"))
		{
            int randomBat = GD.RandRange(1, 5);
			if (randomBat == 1)
			{
				Node2D balls = Prefab.Instantiate<Node2D>();
				balls.GlobalPosition = this.GlobalPosition;
				BallParent.AddChild(balls);
			}			
			if (randomBat == 2)
			{
				Node2D balls = Prefab2.Instantiate<Node2D>();
				balls.GlobalPosition = this.GlobalPosition;
				BallParent.AddChild(balls);
			}		
			if (randomBat == 3)
			{
				Node2D balls = Prefab3.Instantiate<Node2D>();
				balls.GlobalPosition = this.GlobalPosition;
				BallParent.AddChild(balls);
			}			
			if (randomBat == 4)
			{
				Node2D balls = Prefab4.Instantiate<Node2D>();
				balls.GlobalPosition = this.GlobalPosition;
				BallParent.AddChild(balls);
			}
			if (randomBat == 5)
			{
				Node2D balls = Prefab5.Instantiate<Node2D>();
				balls.GlobalPosition = this.GlobalPosition;
				BallParent.AddChild(balls);
			}
        }
	}
}
