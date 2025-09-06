using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		square, as the result is square, and it's the way to multiple a nonsquare matrix to itself;
	///		selfQuare, abbreviated as square
	static public class _MulTransposedX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] MulTranspose(Q[,] a) {
			return matrix.bi_._MultiX._Multiply_1sociable(
				a
				,
				op_.Transpose.Op(a)
			);
		}

		static public Q[,] TransposeMul(Q[,] a) {
			return matrix.bi_._MultiX._Multiply_1sociable(
				op_.Transpose.Op(a)
				,
				a
			);
		}

	}
}
