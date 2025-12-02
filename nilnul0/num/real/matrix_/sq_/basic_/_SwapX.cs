using nilnul.num.real.matrix_._isowide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.basic_
{
	/// <summary>
	/// swap rows, and the result is the same as swapping those two cols
	/// </summary>
	/// alias:
	///		swap
	///			change with another. a change with external.
	///		switch
	///			means change internally
	static public class _SwapX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="size"></param>
		/// <param name="i"></param>
		/// <param name="j">cannot be same as <paramref name="i"/></param>
		/// <returns></returns>
		static public double[,] _Generate_0wide_1row_2other(int size, int i, int j) {
			var r = sq_.Canonic.Create(size);
			 real.matrix.op_.unary_.elementary_.rowwise_._ShuffleX._Shuffle_assumeValid(in r, in i, in j);
			return r;

		}

		/// <summary>
		/// this can be used at the left to swap rows, or at the right to swap cols.
		/// </summary>
		/// <remarks>
		/// for determinant to unchange, negate one row;
		/// the inverse of this is itelf, <see cref="matrix_.sq_.basic_.swap.op_.IInvert"/>
		/// </remarks>
		/// <param name="wide"></param>
		/// <param name="row0col"></param>
		/// <param name="other"></param>
		/// <returns></returns>
		static public Q[,] _Generate8quotient_0wide_1original_2other(int wide, int row0col, int other) {
			var r = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(wide);

			r[row0col, row0col] = 0;
			r[other, other] = 0;

			r[row0col, other] = 1;
			r[other, row0col] = 1;
			return r;
		}
	}
}
