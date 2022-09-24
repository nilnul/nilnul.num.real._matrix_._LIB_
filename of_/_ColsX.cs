using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.of_
{
	static public class _ColsX
	{
		static public double[,] _OfCols_assumeColsSameLength(
			IEnumerable<IEnumerable<double>> cols
		) {

			var colsCount = cols.Count();
			if (colsCount==0 )
			{
				return new double[0, 0];
			}

			var colCardinaltiy=cols.First().Count();

			var rr = new double[
				colCardinaltiy
				,
				colsCount
			];

			for (int i = 0; i < colCardinaltiy; i++)
			{
				for (int j = 0; j < colsCount; j++)
				{
					rr[i, j] = cols.ElementAt(j).ElementAt(i);
				}
			}
			return rr;
		}

		static public double[,] OfParams_assumeColsSameLength(
			params IEnumerable<double>[] cols
		)
		{
			return _OfCols_assumeColsSameLength(cols);
		}

	}
}
