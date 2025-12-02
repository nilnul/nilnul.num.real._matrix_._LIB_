using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.polynom.matrix
{
	static public class _OfX
	{
		/// <see cref="nilnul.num.real.expr_.algebraic.matrix."/>
		/// <summary>
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public P[,] ToPolynomials(this Q4[,] m) {
			int height = m.GetLength(0);
			int width = m.GetLength(1);
			var o = new P[height, width];

			for (int i = 0; i < height; i++) {
				for (int j = 0; j < width; j++)
				{
					o[i, j] = m[i, j];
				}
			}
			return o;
		}
	}
}
