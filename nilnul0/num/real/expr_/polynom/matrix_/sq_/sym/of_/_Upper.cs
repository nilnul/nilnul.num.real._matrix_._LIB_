using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom.matrix_.sq_.sym.of_
{
	static public class _UpperX
	{
		/// <summary>
		/// populate the lower with the upper value;
		/// the diagonal is unchanged.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="m"></param>
		static public void OfUpper<T>(ref T[,] m) {
			int height = m.GetLength(0);
			for (int i = 1; i < height; i++) {
				for (int j = 0; j < i; j++)
				{
					m[i, j] = m[ j,i];
				}
			}

		}
	}
}
