using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Battle_Tanks.Objects
{
	public class Enemy : Vehicle
	{
		public override void Kill()
		{
			throw new NotImplementedException();
		}

		public override void Update()
		{
			throw new NotImplementedException();
		}

		private void _doAI()
		{
			throw new NotImplementedException();
		}

		public Enemy(Point pos, float speed, eDir dir, int hitPoints, Weapon weapon)
			: base(pos,speed,dir,hitPoints,weapon)
		{
			throw new NotImplementedException();
		}
	}
}
