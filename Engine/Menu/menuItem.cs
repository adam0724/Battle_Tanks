using System;
using System.Collections.Generic;
using System.Text;
using QuickFont;

namespace Battle_Tanks.Menu
{
	public class menuItem
	{
		private menuOpen _onClick;
		private int _posX;
		private int _posY;

		public string text
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

		public QFont font
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

		public bool inputItemType
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

		public menuItem()
		{
			throw new NotImplementedException();
		}

		public menuItem(int x, int y, string txt, menuOpen clickFunc, bool inputItem)
		{
			throw new NotImplementedException();
		}

		public void changeText(string newText)
		{
			throw new NotImplementedException();
		}

		public void Render()
		{
			throw new NotImplementedException();
		}
	}
}
