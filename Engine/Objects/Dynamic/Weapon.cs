using System;
using System.Collections.Generic;
using System.Text;

namespace Battle_Tanks.Objects
{
	public class Weapon
	{
		private List <Projectile> _bullets;
		public int damage;
		private Vehicle _owner;
		public float speed;
		public int maxBullets;

		public bool canShoot
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

		public void Shoot()
		{
			throw new NotImplementedException();
		}

		public Weapon(Vehicle owner)
		{
			throw new NotImplementedException();
		}

		public int canDestroyStrongBrick
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
	}
}
