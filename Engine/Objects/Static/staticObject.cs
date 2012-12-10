using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Battle_Tanks.Objects
{
	public class staticObject : virtualObject
	{
		public staticObject(Point pos, eStaticObjType objTyp)
		{
			throw new NotImplementedException();
		}

		public staticObject(Point pos, eStaticObjType objTyp, eSpawnPointType spawnPtTyp)
		{
			throw new NotImplementedException();
		}

		public bool isColideable
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

		public bool isDestroyable
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

		public eStaticObjType objType
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

		public eSpawnPointType spawnPoint
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

		public void Destroy()
		{
			//call: Destroy witch proprer rectangle
			throw new NotImplementedException();
		}
		public virtual void Destroy(Rectangle destroyerBBox)
		{
			throw new NotImplementedException();
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
