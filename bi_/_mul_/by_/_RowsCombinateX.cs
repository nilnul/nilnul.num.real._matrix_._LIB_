using nilnul.num.real.str.op_;
using nilnul.obj.matrix;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.bi_._mul_.by_
{
	/// <summary>
	/// take the right as the operand,
	/// , the first row of the result would be the linear combinate of the rows of the  operand by the first row of the left
	/// </summary>
	static public class _RowsCombinateX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="rows"></param>
		/// <param name="combinator">
		/// a col in the right matrix
		/// </param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _RowsCombinate_1started(
			IEnumerable<double> combinator
			,

			IEnumerable<IEnumerable<double>> rows
		)
		{
			return rows.Zip(combinator, (c, coef) => c.Scale(coef)).Aggregate(

					(a, b) => nilnul.num.real.vec.bi_._AddX._Add_1equisize(a, b)
				);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _RowsCombinate_1started(
			double[] combinator
			,
			IEnumerable<IEnumerable<double>> rows
		)
		{
			return _RowsCombinate_1started((IEnumerable<double>)combinator, rows);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _RowsCombinate_1arity(
			IEnumerable<double> combinator
			,
			int arity
			,
			IEnumerable<IEnumerable<double>> rows
		)
		{
			return _RowsCombinate_1started(
				combinator
				,

				rows.Prepend(Enumerable.Repeat(0d, arity))
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _RowsCombinate_1arity(
			double[] combinator
			,
			int arity
			,
			IEnumerable<IEnumerable<double>> cols
		)
		{
			return _RowsCombinate_1arity(
				(IEnumerable<double>)combinator
				,
				arity,
				cols
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> RowsCombinate(
			IEnumerable<double> combinator
			,
			double[,] matrix
		)
		{
			return _RowsCombinate_1arity(
				combinator
				,
				matrix.GetLength(0)
				,
				matrix.Rows()
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> RowsCombinate(
			double[] combinator
			,
			double[,] matrix
		)
		{
			return RowsCombinate(
				(IEnumerable<double>)combinator
				,
				matrix
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="rows"></param>
		/// <param name="combinators"></param>
		/// <returns>
		/// rows
		/// </returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<IEnumerable<double>> RowsCombinate(
			double[,] combinators
			,
			double[,] rows
		)
		{
			return combinators.Rows().Select(c => RowsCombinate(
				c
				,
				rows
			));
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] RowsCombinateAsMatrix(
			double[,] combinators
			,
			double[,] rows
		)
		{
			var r = new double[combinators.GetLength(0), rows.GetLength(1)];

			RowsCombinate(combinators, rows).Each(
				  (row, index) => row.Each((cel, col) => r[index, col] = cel
				)
			  );
			return r;
		}


	}
}
