using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Battle_Tanks.Visuals
{
	public class Sprite
	{
		public bool destroyWhenAniEnd;
		public static readonly int spriteTexSize = 32;
		private int _currentFrame;
		private int _frameTexWidth;
		private int _height;
		private int _width;
		private Texture _tex;

		private int _framesCount { get{ return _frameTexWidth / _tex.width;	}}

		public int fps { get; private set; }

		public Point pos { get; private set; }

		public Sprite(string texName, Point p)
		{
			_tex = new Texture(texName);
			pos = p;
		}

		public void Render()
		{   /* 0---2 How
             * |  /| Quad
             * | / | is
             * 1/--3 Made */
			// Okreslamy ze bedziemy rysowaæ prostok¹ty (Quads)
			GL.Begin(BeginMode.Quads);
			// Bindujemy teksture wczytana dla tego Sprite'a (o ile istnieje)
			if(_tex!=null)
				GL.BindTexture(TextureTarget.Texture2D, _tex.glTexID );
			
			// Rysujemy wierzcho³ki prostok¹ta wraz z odpowiednymi koordynantami tekstury
			GL.TexCoord2(0, 0);							 // 0
			GL.Vertex2(pos.X, pos.Y);					 // 0
			GL.TexCoord2(0, 1);							 // 1
			GL.Vertex2(pos.X, pos.Y + _height);			 // 1
			GL.TexCoord2(1, 0);							 // 2
			GL.Vertex2(pos.X + _width, pos.Y);			 // 2
			GL.TexCoord2(1, 1);							 // 3
			GL.Vertex2(pos.X + _width, pos.Y + _height); // 3
			// Konczymy rysowanie prostok¹ta:
			GL.End();
		}
		public void setPosAbs(Point position)
		{
			pos = position;
		}
		public void move(Point mov)
		{
			pos.Offset(mov);
		}
	}
}
