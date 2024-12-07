using Godot;
using System;

public partial class Balls : Node2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        int rng = GD.RandRange(0, 5);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        RigidBody2D bbBall = GetNode<RigidBody2D>("BB Ball");
        RigidBody2D hwBall = GetNode<RigidBody2D>("HW Ball");
        RigidBody2D lbbBall = GetNode<RigidBody2D>("LBB Ball");
        RigidBody2D erbBall = GetNode<RigidBody2D>("ERB Ball");
        RigidBody2D gfbBall = GetNode<RigidBody2D>("GFB Ball");
        RigidBody2D vbBall = GetNode<RigidBody2D>("VB Ball");
        RigidBody2D hhBall = GetNode<RigidBody2D>("HH Ball");
        RigidBody2D snbBall = GetNode<RigidBody2D>("SNB Ball");
        RigidBody2D bebBall = GetNode<RigidBody2D>("BEB Ball");
        RigidBody2D lnbBall = GetNode<RigidBody2D>("LNB Ball");
        RigidBody2D ffbBall = GetNode<RigidBody2D>("FFB Ball");
    }
}
