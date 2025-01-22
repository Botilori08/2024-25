﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace kraterek
{
	internal class Krater
	{
		public double x;
		public double y;
		public double r;
		public string nev;

		public Krater(string sor)
		{
			string[] vag = sor.Split("\t");

			x = double.Parse(vag[0]);
			y= double.Parse(vag[1]);
			r = double.Parse(vag[2]);
			nev = vag[3];

		}

		public override string ToString()
		{
			return $"A(z) {nev} kozeppontja X={x} Y={y} sugara R={r}.";
		}

	}
}
