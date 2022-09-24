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


namespace nilnul.num.real.matrix.grid.co_.cols1cols_.multible
{
	//[Obsolete(nameof(num.real.vec.str._LinearCombinateX._LinearCombinate_assumeEquicount))]
	static public class _MultiX
	{



		/// <summary>
		/// 
		/// </summary>
		/// <param name="cols">n*m</param>
		/// <param name="col">
		///m*1. as a vec, its arity is m
		/// </param>
		/// <returns>
		/// n*1; a vec of n.
		/// </returns>
		/// <see cref="num.real.vec.str.co._Multi2matrixX"/>
		public static IEnumerable<double> _MultiplyAsNulable_cols1colAssumeMultible(
			this IEnumerable<IEnumerable<double>> cols
			,
			 IEnumerable<double> col
		)

		{
			return num.real.vec.str.accumulate_._LinearCombinateX._LinearCombinateAsNullable_assumeEquicount(
				cols, col
			);
			///by transpose
			return rows1rows_.multible._MultiX._MultiplyAsNulable_row1rowsAssumeMultible(col, cols);
		}


		public static IEnumerable<IEnumerable<double>> _MultiAsColNulableEs_cols1colsAssumeMultible(
			this
			IEnumerable<IEnumerable<double>> cols
			,
			 IEnumerable<IEnumerable<double>> col
		)

		{

			return col.Select(
				r => _MultiplyAsNulable_cols1colAssumeMultible(cols, r)
			);




		}

		public static double[,] _MultiAsColsNulable_cols1colsAssumeMultible(
			this
			IEnumerable<IEnumerable<double>> cols
			,
			 IEnumerable<IEnumerable<double>> col
		)

		{
			if (cols.Any())
			{
				if (col.Any())
				{
					return num.real.matrix.of_._ColsX._OfCols_assumeColsSameLength(
						col.Select(
							r => _MultiplyAsNulable_cols1colAssumeMultible(cols, r)
						)
					);

				}
				return new double[cols.First().Count(), 0];

			}
			
			return null;
			


		}
	}
}
