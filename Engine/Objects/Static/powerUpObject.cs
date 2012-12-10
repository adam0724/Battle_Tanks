using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Battle_Tanks.Time;

namespace Battle_Tanks.Objects
{
	public class powerUpObject : staticObject
	{
		Timer blinkTimer;

		public powerUpObject(Point pos, eStaticObjType objTyp, ePowerUpType powTyp)
			: base(pos,objTyp)
		{

		}
		public ePowerUpType powerUpType
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public override void Update()
		{
			throw new NotImplementedException();
		}

		public override void Render()
		{
			throw new NotImplementedException();
		}
	}
}
