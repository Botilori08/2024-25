using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.WebRequestMethods;

namespace versek
{
	internal class Vers
	{
		public string felelos;
		public string versSzerzo;
		public string versCim;
		public string datum;

		public Vers(string felelos, string versSzerzo, string versCim, string datum)
		{
			this.felelos = felelos;
			this.versSzerzo = versSzerzo;
			this.versCim = versCim;
			this.datum = datum;

		}

		public string osszefuz()
		{
			return $"{this.felelos} ; {this.versSzerzo} - {this.versCim} ; {this.datum}";
		}

		public static string ekezetEltav(string text)
		{
			if (string.IsNullOrWhiteSpace(text))
				return text;

			var normalized = text.Normalize(NormalizationForm.FormD); // ékezetes karakterek lebontása
			var builder = new StringBuilder();

			foreach (var c in normalized)
			{
				var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
				if (unicodeCategory != UnicodeCategory.NonSpacingMark)
				{
					builder.Append(c);
				}
			}

			return builder.ToString().Normalize(NormalizationForm.FormC); // újranormalizálás (nem kötelező)
		}

		public string URL()
		{
			string[] vag = this.versSzerzo.Split(" ");
			string[] cimVag = this.versCim.Split(" ");

			string[] rosszKarakterek = ["?","!","...",".",","];

			for (int i = 0; i < vag.Length; i++)
			{
                for (int j = 0; j < rosszKarakterek.Length; j++)
                {
                    vag[i] = Vers.ekezetEltav(vag[i]).ToLower().Replace(rosszKarakterek[j], "");
                }
			}


			for (int i = 0; i < cimVag.Length; i++)
			{
				for(int j = 0; j < rosszKarakterek.Length;j++)
				{
					cimVag[i] = Vers.ekezetEltav(cimVag[i]).ToLower().Replace(rosszKarakterek[j],"");
				}
				
			}

			return "https://adyakszemle.hu/"+String.Join("-",vag)+"-"+ String.Join("-", cimVag) + "/";
		}
	}
}
