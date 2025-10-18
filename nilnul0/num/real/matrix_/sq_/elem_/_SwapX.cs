using nilnul.num.real.matrix_._isowide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.elem_
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
		static public double[,] _Generate_0wide_1row_2other(int size, int i, int j) {
			var r = sq_.Canonic.Create(size);
			 real.matrix.op_.unary_.elementary_.rowwise_._ShuffleX._Shuffle_assumeValid(in r, in i, in j);
			return r;

		}
		static public Q[,] _Generate8quotient_0wide_1row_2other(int wide, int row, int other) {
			var r = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(wide);

			r[row, row] = 0;
			r[other, other] = 0;

			r[row, other] = 1;
			r[other, row] = 1;
			return r;
		}
	}
}
