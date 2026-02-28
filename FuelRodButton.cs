using Godot;
using System;

public partial class FuelRodButton : TextureButton
{
	public static FuelRodButton Instance { get; private set; }
	//public int FRP { get; set; }
	public int FRP = 1;
	public int FRO = 0;
	
	public void FRPChange()
	{
		if(FRP == 1)
		{
			FRP = 2;
			FRO = 0;
			System.Console.WriteLine("ChangedPosTo2From1");
		}
		else if(FRP == 2)
		{
			if(FRO == 0)
			{
				FRP = 3;
				System.Console.WriteLine("ChangedPosTo3");
			}
			if(FRO == 1)
			{
				FRP = 1;
				System.Console.WriteLine("ChangedPosTo1");
			}
		}
		else
		{
			FRP = 2;
			FRO = 1;
			System.Console.WriteLine("ChangedPosTo2From3");
		}
	}
}
