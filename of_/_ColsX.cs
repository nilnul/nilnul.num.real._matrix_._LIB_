using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.of_
{
	static public class _ColsX
	{
		static public double[,] _OfCols_assumeColsSameLength(
			IEnumerable<IEnumerable<double>> cols
		)
		{

			var colsCount = cols.Count();
			if (colsCount==0)
			{
				return new double[0, 0];
			}

			var colCardinaltiy = cols.First().Count();

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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _OfCols_0high(
			int high
			,
			IEnumerable<IEnumerable<double>> rows
		)
		{
			return nilnul.obj.matrix.of_._OfColsX._OfCols_0high(high, rows);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _OfCols_0high(
			int high
			,
			IEnumerable<IEnumerable<Q>> rows
		)
		{
			return nilnul.obj.matrix.of_._OfColsX._OfCols_0high(high, rows);

		}




	}
}
