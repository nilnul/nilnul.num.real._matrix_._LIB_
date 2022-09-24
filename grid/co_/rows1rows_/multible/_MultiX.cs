using nilnul.obj.matrix.co.be_.multible.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;


namespace nilnul.num.real.matrix.grid.co_.rows1rows_.multible
{
	//[Obsolete(nameof(num.real.vec.str._LinearCombinateX._LinearCombinate_assumeEquicount))]
	static public class _MultiX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="row">
		/// 1*n matrix.
		///
		/// </param>
		/// <param name="rows">
		///		n*m matrix
		/// </param>
		/// <returns>
		///1*m, in the form of a row.
		/// </returns>
		/////
		//[Obsolete(nameof(num.real.vec.str.accumulate_._LinearCombinateX._LinearCombinate_assumeEquicount)
		////, true
		//	)]
		public static IEnumerable<double> _MultiplyAsNulable_row1rowsAssumeMultible(
			this IEnumerable<double> row
			,
			IEnumerable<IEnumerable<double>> rows
		)
		{
			return num.real.vec.str.accumulate_._LinearCombinateX._LinearCombinateAsNullable_assumeEquicount(
				rows, row
			);

		}

		public static IEnumerable<IEnumerable<double>> _MultiplyAsRowNulableEs_rows1rowsAssumeMultible(
			this IEnumerable<IEnumerable<double>> rowsAtLeft
			,
			IEnumerable<IEnumerable<double>> rowsAsBases
		)
		{
			return rowsAtLeft.Select(r => _MultiplyAsNulable_row1rowsAssumeMultible(r, rowsAsBases));

		}

		public static double[,] _MultiplyAsRowsNulable_rows1rowsAssumeMultible(
			this IEnumerable<IEnumerable<double>> rowsAtLeft
			,
			IEnumerable<IEnumerable<double>> bases
		)
		{
			if (bases.Any())
			{
				if (rowsAtLeft.Any())
				{
					return
						 num.real.matrix.of_._RowsX._OfRows_assumeRowsSameLength(
							rowsAtLeft.Select(r => _MultiplyAsNulable_row1rowsAssumeMultible(r, bases))
						);

				}
				else
				{
					return new double[0,bases.First().Count()];
				}
			}
			
			return null;

		}

	}
}
