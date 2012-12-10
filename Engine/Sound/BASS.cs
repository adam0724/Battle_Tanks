using System;
using System.Collections.Generic;
using System.Text;

namespace Battle_Tanks.Sound
{
	public static class BASS
	{
		public const uint BASS_STREAM_AUTOFREE = 0x40000;

		public static bool BASS_Init(int device, int freq, int flags, int win, object clsid)
		{
			throw new NotImplementedException();
		}

		public static bool BASS_Free()
		{
			throw new NotImplementedException();
		}

		public static int BASS_StreamCreateFile(bool mem, String str, UInt64 offset, UInt64 length, int flags)
		{
			throw new NotImplementedException();
		}

		public static bool BASS_StreamFree(int handle)
		{
			throw new NotImplementedException();
		}

		public static bool BASS_ChannelPlay(int handle, bool restart)
		{
			throw new NotImplementedException();
		}
	}
}
