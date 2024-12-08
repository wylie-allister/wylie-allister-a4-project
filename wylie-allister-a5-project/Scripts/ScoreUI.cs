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

	public void ScoreAdd(int points)
	{
		//makes score equal points & updates score
		score = points;
		UpdateScreen();
	}

	private void UpdateScreen()
	{
		//prints score to screen
		Text = $"SCORE: {score}";
		GD.Print(score);
	}
}
