using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.matrix_.sq_
{
	static public class _VandermondeX
	{
		static public double[,] Matrix(IEnumerable<double> x) {

			int dimension = x.Count();

			//int dimensionMinus = dimension - 1;

			var r = nilnul.num.real.matrix_._SquareX.Init8dbl(
				dimension

			);
			if (dimension==0)
			{
				return r;
				return new double[0,0];
			}

			for (int row = 0; row < dimension; row++)
			{
				var val = x.ElementAt(row);

				var cel = 1d;
				r[row, 0] = cel;
	
				for (int col = 1; col < dimension; col++)
				{
					r[row, col] = cel*= val;
				}
			}
			return r;
		}
	}
}
