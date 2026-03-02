using Godot;
using System;

public partial class ClockBreaking : TextureButton
{
	public int NOTP = 0;
	public void ClockClicked()
	{
		NOTP += 1;
	}
	public override void _Process(double delta)
	{
		if(NOTP == 4)
		{
			string newTexturePath = "res://.godot/imported/Clock Broken No Hands.aseprite-7442d22ecfe71686a5a84e7bf20b5fd2.ctex";
			System.Console.WriteLine("The Other Code Works");
		}
	}
}
