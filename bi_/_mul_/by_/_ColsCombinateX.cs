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
	/// take the left as the operand,
	/// , the first col of the result would be the linear combinate of the cols of the first operand by the first col of the right
	/// </summary>
	static public class _ColsCombinateX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cols"></param>
		/// <param name="combinator">
		/// a col in the right matrix
		/// </param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _ColsCombinate_0started(
			IEnumerable<IEnumerable<double>> cols
			,
			IEnumerable< double> combinator
		) {
			return				cols.Zip( combinator, (c,coef) => c.Scale(coef) ).Aggregate(

					(a,b) => nilnul.num.real.vec.bi_._AddX._Add_1equisize(a,b)
				);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _ColsCombinate_0started(
			IEnumerable<IEnumerable<double>> cols
			,
			double[] combinator
		) {
			return	_ColsCombinate_0started(cols, (IEnumerable< double>)combinator );
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _ColsCombinate_0arity(
			int arity
			,
			IEnumerable<IEnumerable<double>> cols
			,
			IEnumerable< double> combinator
		) {
			return		_ColsCombinate_0started(
				
				cols.Prepend(Enumerable.Repeat(0d, arity))
				,
				combinator
			)		;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _ColsCombinate_0arity(
			int arity
			,
			IEnumerable<IEnumerable<double>> cols
			,
			double[] combinator
		) {
			return _ColsCombinate_0arity(
				arity,
				cols,
				(IEnumerable< double>)combinator
			)		;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> ColsCombinate(
			double[,] matrix
			,
			IEnumerable< double> combinator
		) {
			return _ColsCombinate_0arity(
				matrix.GetLength(0)
				,
				matrix.Cols()
				,
				combinator
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> ColsCombinate(
			double[,] matrix
			,
			double[] combinator
		) {
			return ColsCombinate(
				matrix
				
				,
				(IEnumerable< double>)combinator
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cols"></param>
		/// <param name="combinators"></param>
		/// <returns>
		/// cols
		/// </returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  IEnumerable<IEnumerable<double>> ColsCombinate(
			double[,] cols
			,
			double[,] combinators
		) {
			return combinators.Cols().Select( c=> ColsCombinate(
				cols
				,
				c
			));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] ColsCombinateAsMatrix(
			double[,] combinators
			,
			double[,] rows
		)
		{
			var r = new double[combinators.GetLength(0), rows.GetLength(1)];

			ColsCombinate(combinators, rows).Each(
				  (col, index) => col.Each((cel, row) => r[row,index] = cel
				)
			  );
			return r;
		}



	}
}
