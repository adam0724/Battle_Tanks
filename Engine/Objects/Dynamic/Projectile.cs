using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Battle_Tanks.Objects
{
	public class Projectile : dynamicObject
	{
		private Vehicle _firedBy;

		public Projectile(Point pos, float speed, eDir dir, Vehicle owner)
			: base(pos,speed,dir)
		{
			throw new NotImplementedException();
		}

		public override void Update()
		{
			throw new NotImplementedException();
		}
	}
}
