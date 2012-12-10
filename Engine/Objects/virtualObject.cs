using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Battle_Tanks.Visuals;

namespace Battle_Tanks.Objects
{
	public abstract class virtualObject
	{
		protected Sprite visual;
		protected Rectangle bBox;
		protected Point gridPos;
		protected Point Pos;
		protected static Engine gameEngine;

		public Rectangle boundingBox
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public virtual void Update()
		{
			throw new NotImplementedException();
		}

		public virtual void Render()
		{
			throw new NotImplementedException();
		}
	}
}
