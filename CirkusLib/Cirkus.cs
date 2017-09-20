using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CirkusLib
{
	public class Cirkus
	{

		private string name;
		public int counterAntalCirkus;
		public int antalAnställda;
		public int antalUppträdanden;

		Dictionary<Artist, int> Artists = new Dictionary<Artist, int>();

		public Cirkus(string name)
		{
			this.name = name;
		}

		public Cirkus()
		{
			counterAntalCirkus++;
		}

		public void Anställ(Artist artist)
		{
			Artists.Add(artist, 0);
			antalAnställda++;
		}

		public void ArtistUppträdande(Artist artist)
		{
			Artists[artist]++;
				//antalUppträdanden++;
		}

		public override string ToString()
		{
			string sufix = "";
			string gånger = "";

			foreach (var artist in Artists)
			{
				var artname = artist.Key.name;

				if (artist.Value != 1)
					gånger = "gånger";
				else
					gånger = "gång";

				sufix += $"{artname} har uppträtt {artist.Value} {gånger}.";
			}

			return $"Cirkusen Victoria har {antalAnställda} artister. " + sufix; 
			
		}
	}
}
