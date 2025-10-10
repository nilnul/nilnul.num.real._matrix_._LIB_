using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.str.co.to_
{
	static public class _OuterProductX
	{
		/// <summary>
		/// a row as matrix times a col as a matrix.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public double[,] OuterProduct(
			double[] a
			,
			double[] b
		) {
			int rows = a.Length;
			int cols = b.Length;

			var r = new double[rows,cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] = a[i]*b[j];
				}
			}
			return r;

		}
	}
}
