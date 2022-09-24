using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_
{

	static public class _RowX
	{
		static public double[,] Matrix4dbl(IEnumerable<double> str) {
			var c = str.Count();
			var r = new double[1, c];

			for (int i = 0; i < c; i++)
			{
				r[1, i] = str.ElementAt(i);

			}
			return r;
		}
		static public double[,] Matrix4dbl(params double[] str) {
			return Matrix4dbl(
				(IEnumerable<double>)str
			);
		}

	}
}
