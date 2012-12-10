using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using Battle_Tanks.Menu;
using Battle_Tanks.Objects;
using Battle_Tanks.Sound;
using Battle_Tanks.Visuals;
using Battle_Tanks.Time;

namespace Battle_Tanks
{
	public class Engine : OpenTK.GameWindow
	{
		private List<Enemy> _enemiesOnMap;
		private List<Enemy> _enemiesToAdd;
		private Player _player1;
		private Player _player2;
		private List<powerUpObject> _powerUps;
		private List<Projectile> _projectiles;
		private statistics _stats;
		private menuManager _menuMgr;
		private soundManager _sndMgr;
		private timeManager _timeMgr;
		private staticObject[] _staticObjects;

		/// <summary>
		/// Inicjuje silnik gry czyli:
		/// (?)(TODO)
		/// </summary>
		public Engine()
			: base(1024,768)
		{
		}

		/// <summary>
		/// Obecny poziom (stage) gry.
		/// </summary>
		public int currentLevel	{ get;	private set; }

		/// <summary>
		/// Punkty w kt�rych odradzaj� si� przeciwnicy na obecnej mapy, ta lista jest wype�niania
		/// przy ka�dym �adowaniu mapy - powiedzmy ze u nas spawn-pointy sa zaznaczane 
		/// na mapie i nie musz� by� to zawsze te same punkty.
		/// </summary>
		public List<staticObject> enemySpawnPoints { get; private set; }
		/// <summary>
		/// Warto�� oznaczaj�ca maksymaln� ilo�� przeciwnik�w na mapie na raz, liczba bedzie ustawiana na inn�
		/// zale�nie od tego czy wybrano tryb dla 1 czy dla wielu graczy, tak�e kolejne poziomy mogly by zwieksza� ilo��
		/// przeciwnikow na mapie (POMYS�).
		/// </summary>
		public int maxEnemiesOnMap { get; private set; }
		/// <summary>
		/// Tablica z 2 obiektami klasy Controls kazda dla 1 z graczy
		/// 0 - 1 gracz
		/// 1 - 2 gracz
		/// </summary>
		public Controls[] playerControls { get; private set; }

		/// <summary>
		/// Obecny stan gry (MENU/GAME)
		/// </summary>
		public eGameState state { get; private set; }

		/// <summary>
		/// Metoda dodaj�ca pocisk do listy _Projectiles
		/// </summary>
		/// <param name="proj"></param>
		public void addProjectile(Projectile proj)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sprawdza kolizje dynamiczn� obiektu z innymi obiektami (dynamicznymi)
		/// </summary>
		/// <param name="obj">Obiekt kt�rego kolizja ma zosta� sprawdzona</param>
		/// <returns>Lista obiekt�w z ktorymi koliduje, null jezeli takowych brak</returns>
		public List<dynamicObject> checkCollisionDyn(dynamicObject obj)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Sprawdza kolizje statyczna obiektu z innymi obiektami (statycznymi)
		/// Obiekt dynamiczny mo�e kolidowa� tylko z jednym polem statycznym na raz.
		/// </summary>
		/// <param name="obj">Obiekt kt�rego kolizja ma zosta� sprawdzona</param>
		/// <returns>Obiekt statyczny z kt�rym koliduje dany obiekt dynamiczny</returns>
		public staticObject checkCollisionStat(dynamicObject obj)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Wczytuje gr� z podanego jako parrametr obiektu Savegame
		/// </summary>
		/// <param name="sav">Savegame do wczytania</param>
		public void loadGame(Savegame sav)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Odtwarza plik d�wi�kowy
		/// Funkcja w�a�ciwie poprostu przekazuje parrametr dalej do soundManagera i jego playStream
		/// </summary>
		/// <param name="filename"></param>
		public void playSound(string filename)
		{
			throw new NotImplementedException();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			_initMatrix();
			GL.Enable(EnableCap.DepthTest);
			GL.Enable(EnableCap.Texture2D);
			GL.Enable(EnableCap.Blend);
			//Ustawiamy kolor czyszczenia(tla):
			GL.ClearColor(OpenTK.Graphics.Color4.CadetBlue);
		}

		/// <summary>
		/// Funkcja nadpisuj�ca t� sam� funkcje klasy GameWindow ma za zadanie zale�nie od obecnego stanu gry:
		/// *MENU - wywo�a� Render menuManagera
		/// *GAME - wywo�a� Render wszystkich statycznycch obiekt�w mapy, pojazd�w gracza i wroga a na koniec pocisk�w i power-up�w.
		/// </summary>
		protected override void OnRenderFrame(FrameEventArgs e)
		{
			base.OnRenderFrame(e);
			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

			GL.Begin(BeginMode.Quads);
			GL.Color3(1.0, .0, 1.0);
			GL.Vertex2(100 ,40);
			GL.Vertex2(100 ,240);   
			GL.Vertex2(300 ,240);
			GL.Vertex2(300 ,40 );
			GL.End();
			SwapBuffers();
		}
		/// <summary>
		/// Funkcja nadpisuj�ca t� sam� funkcje klasy GameWindow ma za zadanie zale�nie od obecnego stanu gry:
		/// *MENU - wywo�a� Render menuManagera
		/// *GAME - wywo�a� Render wszystkich statycznycch obiekt�w mapy, pojazd�w gracza i wroga a na koniec pocisk�w i power-up�w.
		/// </summary>
		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			base.OnUpdateFrame(e);
		}
		/// <summary>
		/// Metoda utworzy odpowiedni obiekt dla danego jako argument piksela
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		private void _createObjectFromMapPixel(int x, int y)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Inicjalizacja macierzu przeksztalce�
		/// wymagane do prawidlowego wy�wietlania obiek�w
		/// graficznych.
		/// </summary>
		private void _initMatrix()
		{
			int[] viewPort = new int[4];

			GL.GetInteger(GetPName.Viewport, viewPort);
			GL.MatrixMode(MatrixMode.Projection);
			GL.PushMatrix();
			GL.LoadIdentity();

			GL.Ortho(viewPort[0], viewPort[0] + viewPort[2], viewPort[1] + viewPort[3], viewPort[1], -1, 1);
			GL.MatrixMode(MatrixMode.Modelview);
			GL.PushMatrix();
			GL.LoadIdentity();
			//GL.Translate(0.375, 0.375, 0.0);
			GL.Translate(0.0, 0.0, 0.0);
			GL.PushAttrib(AttribMask.DepthBufferBit);
		}

		/// <summary>
		/// Metoda wywolana przy zakonczeniu gry
		/// </summary>
		private void _gameOver()
		{
			throw new NotImplementedException();
		}

		private List<Enemy> _generateEnemies()
		{
			throw new NotImplementedException();
		}

		private void _generateMap()
		{
			throw new NotImplementedException();
		}

		private void _loadMap(string path)
		{
			throw new NotImplementedException();
		}

		private void _nextLevel()
		{
			throw new NotImplementedException();
		}

		private static void _SpawnVehicle(Vehicle tank)
		{
			throw new NotImplementedException();
		}
		// Entry Point (Main):
		[STAThread]
		static void Main()
		{
			using (Engine game = new Engine())
			{
				game.VSync = VSyncMode.Adaptive;
				game.Title = "Battle Tanks";
				game.Run(60);
			}
		}
	}



}
