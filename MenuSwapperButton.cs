using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class MenuSwapperButton : TextureButton
{
	[Export] Node SwitchToMenu;
	
	public override void _Ready()
	{
		Pressed += OnMenuSwapperButtonPressed;
	}
	
	private void OnMenuSwapperButtonPressed()
	{
		if(GetParent().GetParent() is MenuTab menuTab){
			menuTab.OnMenuSwapButtonPressed(SwitchToMenu.GetIndex());
		}
	}
}
