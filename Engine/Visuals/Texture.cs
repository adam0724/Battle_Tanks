using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using OpenTK.Graphics.OpenGL;

namespace Battle_Tanks.Visuals
{
	/// <summary>
	/// Obiekty klasy to pojedyñcze tekstury inicjalizowane przez wczytanie bitmapy
	/// z podanej przy konstruktorze nazwy tekstury. Podczas konstrukcji wype³niane
	/// s¹ dane dot. wymiarów tekstury.
	/// </summary>
	public class Texture
	{
		/// <summary>
		/// Œcie¿ka dostepu do folderu z teksturami.
		/// </summary>
		static string texturesPath = "";
		/// <summary>
		/// Identyfikator tekstury przypisany przez openGL przy generowaniu.
		/// </summary>
		public int glTexID {get; private set;}

		/// <summary>
		/// Szerokoœæ tekstury
		/// </summary>
		public int width { get; private set; }
		/// <summary>
		/// Wysokoœæ tekstury
		/// </summary>
		public int height { get; private set; }

		/// <summary>
		/// Konstruktor klasy texture przeprowadza ca³y proces generowania
		/// tekstury openGL.
		/// </summary>
		/// <param name="texName">Nazwa pliku z którego ma zostaæ utworzona tekstura.</param>
		public Texture(string texName)
		{	// Wczytanie bitmapy za pomoc¹ obiektu Bitmap z System.Drawing:
			Bitmap bitmap = new Bitmap(texturesPath+texName);
			width = bitmap.Width;
			height = bitmap.Height;

			// Utworzenie obiektu bitmapData z którego póŸniej bitmapa bêdzie obs³u¿ona przez openGL
			BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
				ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

			// Generujemy nowa teksture w openGL oraz bindujemy j¹
			// (Kolejne operacje z GL.Tex* bêda wykonywane dla niej)
			glTexID = GL.GenTexture();
			GL.BindTexture(TextureTarget.Texture2D, glTexID);

			// Do openGL'owej tekstury wstawiamy dane obrazka wczesnienj wczytanego do bitmapData:
			GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
				OpenTK.Graphics.OpenGL.PixelFormat.Rgba, PixelType.UnsignedByte, data.Scan0);
			// Po odczycie z bitmapy mo¿na j¹ odblokowaæ.
			bitmap.UnlockBits(data);

			// Filtrowanie tekstury, inaczej przy jakimkolwiek skalowaniu (mniejsze wieksze)
			// bitmapy wyswietli nam sie tylko biel
			GL.TexEnv(TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (float)TextureEnvMode.Modulate);
			GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
			GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
		}
	}
}
