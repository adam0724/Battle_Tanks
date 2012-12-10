using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Battle_Tanks.Objects
{
	public class staticObjectGroup : staticObject
	{
		List <staticObject> objsGroup;

		public override void Destroy(Rectangle destroyerBBox)
		{
			throw new NotImplementedException();
		}

		public override void Update()
		{
			throw new NotImplementedException();
		}

		public void Render()
		{
			throw new NotImplementedException();
		}

		private void _Add(staticObject SOB)
		{
			throw new NotImplementedException();
		}

		public staticObjectGroup(Point pos, eStaticObjType objType, eSOBQuarters quarters)
		: base(pos,objType)
		{
			throw new NotImplementedException();
		}
	}
}
