using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.isosize.bi_.celwise_
{
	static public class _MultiplyX
	{
		static public void _Multiply_1isosize(ref Q[,] a, Q[,] b) {

			int h = a.GetLength(0);
			int w = a.GetLength(1);

			for (int i = 0; i < h; i++)
			{
				for (int j = 0; j < w; j++)
				{
					a[i,j] *= b[i, j];
				}
			}
		}
		static public Q[,] _Multiply_1isosize( Q[,] a, Q[,] b) {

			var t = (Q[,]) a.Clone();

			_Multiply_1isosize(ref t, b);
			return t;
		}


	}
}
