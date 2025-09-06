using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.of_
{
	static public class _RowsX
	{
		static public double[,] _OfRows_assumeRowsSameLength(
			IEnumerable<IEnumerable<double>> rows
		)
		{

			var rowsCount = rows.Count();
			if (rowsCount == 0)
			{
				return new double[0, 0];
			}

			var rowCardinaltiy = rows.First().Count();

			var r = new double[
				rowsCount
				,
				rowCardinaltiy
			];

			for (int j = 0; j < rowsCount; j++)
			{
				for (int i = 0; i < rowCardinaltiy; i++)
				{
					r[j, i] = rows.ElementAt(j).ElementAt(i);
				}
			}
			return r;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static public Q[,] _OfRows_0started1unisize(
			IEnumerable<IEnumerable<Q>> rows
		)
		{
			return nilnul.obj.matrix.of_.vecs_._OfRowsX._OfVecs_assumeSameArity(rows);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] OfParams_assumeRowsSameLength(
			params IEnumerable<double>[] cols
		)
		{
			return _OfRows_assumeRowsSameLength(cols);
		}

	}
}
