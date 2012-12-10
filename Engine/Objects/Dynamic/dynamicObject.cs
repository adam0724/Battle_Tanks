using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Battle_Tanks.Objects
{
	public abstract class dynamicObject : virtualObject
	{
		protected float speed;

		public eDir direction
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

		public void Move(int x, int y)
		{
			throw new NotImplementedException();
		}

		public void MoveAbs(int x, int y)
		{
			throw new NotImplementedException();
		}

		public void Move(Point p)
		{
			throw new NotImplementedException();
		}

		public void MoveAbs(Point p)
		{
			throw new NotImplementedException();
		}

		public override void Update()
		{
			throw new NotImplementedException();
		}

		protected dynamicObject(Point pos, float speed, eDir dir)
		{
			throw new NotImplementedException();
		}
	}
}
