using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.endomul_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _AtTransposedX
	{



		/// <summary>
		/// A^T A 
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] TransposeMul(Q[,] a) {
			return matrix.bi_._MultiX._Multiply_1sociable(
				op_.Transpose.Op(a)
				,
				a
			);

			//return MulTranspose(
			//	op_.Transpose.Op(a)

			//);


		}

	}
}
