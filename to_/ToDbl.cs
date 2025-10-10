using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.to_
{
	static public class _ToDblX
	{
		static public double[,] ToDoubles(this Q[,] m) {

			int rows = m.GetLength(0);

			int cols = m.GetLength(1);

			var r = new double[rows,cols];

			for (int i = 0; i < rows; i++) {
				for (int j = 0; j < cols; j++)
				{
					r[i, j] =nilnul.num.quotient.to_._DblX.ToDbl_byInt2dbl( 
						m[i, j]
					);
				}
			}

			return r;


		}
	}
}
