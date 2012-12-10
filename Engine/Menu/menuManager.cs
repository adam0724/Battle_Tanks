using System;
using System.Collections.Generic;
using System.Text;
using QuickFont;
namespace Battle_Tanks.Menu
{
	public class menuManager
	{
		public static QFont menuFont;
		public static QFont menuFontActive;
		public static QFont menuFontSmall;
		public static QFont menuFontAlt;

		public Menu currentMenu
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

		public event EventHandler keyUp;

		public void Render()
		{
			throw new NotImplementedException();
		}
	}
}
