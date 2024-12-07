using Godot;
using System;

public partial class ScoreUI : Label
{
	private int score;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		UpdateScreen();
	}

	public void ScoreAdd(Dropper ball)
	{
		score += ball.points;
		UpdateScreen();
	}

	private void UpdateScreen()
	{
		Text = $"SCORE: {score}";
		GD.Print(score);
	}
}
