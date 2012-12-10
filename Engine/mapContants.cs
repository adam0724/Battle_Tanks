using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Battle_Tanks
{
	public static class mapContants
	{
		public static readonly Color BUSH = Color.FromArgb(255, 0, 255, 0);//green
		public static readonly Color WATER = Color.FromArgb(255, 0, 0, 255);//blue
		public static readonly Color[] BRICK = new Color[GroupedObjArraySize];
		public static readonly Color[] BRICK_HARD = new Color[GroupedObjArraySize];
		public static readonly int GroupedObjArraySize = 16;
	}
}
