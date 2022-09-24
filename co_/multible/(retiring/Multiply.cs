using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.tuple
{
	public partial class Multiply
	{
		public static uint[,] ToArray(uint [,] a, uint[,] b) {


			///
			var gageLen = a.GetLength(1);

			if (gageLen!=b.GetLength(0))
			{
				throw new Exception("a.N!=b.M.");
				
			}


			uint[,] c = new uint[a.GetLength(0), b.GetLength(1)];

			for (int i = 0; i < c.GetLength(0); i++)
			{
				for (int j = 0; j < c.GetLength(1); j++)
				{

					for (int k = 0; k < gageLen; k++)
					{
						c[i, j] += a[i, k] * b[k, j];
						
					}
					
				}
				
			}
			return c;


		}
	}
}
