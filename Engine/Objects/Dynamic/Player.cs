using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Battle_Tanks.Objects
{
	public class Player : Vehicle
	{
		private int _playerID;
		private int _oldHp;

		public override void Update()
		{
			throw new NotImplementedException();
		}
		public void KeyEvent(OpenTK.KeyPressEventArgs arg)
		{
			throw new NotImplementedException();
		}

		public override void Kill()
		{
			throw new NotImplementedException();
		}

		public Player(int ID, Point pos, float speed, eDir dir, int hitPoints, Weapon weapon)
		: base(pos,speed,dir,hitPoints,weapon)
		{
			throw new NotImplementedException();
		}

		public int points
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

		public int totalPoints
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

		public int lives
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

		public void loadScore(Savegame sav)
		{
			throw new NotImplementedException();
		}
	}
}
