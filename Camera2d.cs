using Godot;
using System;

public partial class Camera2d : Camera2D
{
	[Export]
	public float MaxOffset { get; set; } = 100.0f; 
	[Export]
	public float FollowSpeed { get; set; } = 20.0f;
	private Vector2 _centerViewport;
	public override void _Ready()
	{
		_centerViewport = GetViewportRect().Size / 2.0f;
		//GameMain Main = GetNode<GameMain>("Main");
	}
	public override void _Process(double delta)
	{
		//if (Node2D.GameMain.interacting = false) 
		{
			Vector2 mousePosition = GetViewport().GetMousePosition();  
			float offsetX = ((mousePosition.X / _centerViewport.X) - 1.0f) * MaxOffset;
			float offsetY = ((mousePosition.Y / _centerViewport.Y) - 1.0f) * MaxOffset;
			Vector2 targetOffset = new Vector2(offsetX, offsetY);
			Offset = Offset.Lerp(targetOffset, FollowSpeed * (float)delta);
		}
	}
}
