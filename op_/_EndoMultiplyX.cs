using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_
{
	/// <see cref="real.matrix.op_.IEndoMultiply"/>
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		square, as the result is square, and it's the way to multiple a nonsquare matrix to itself;
	///		selfQuare, abbreviated as square
	///		promulgate
	///		, 
	///		mulTranspose: A A^T is more canonical as it has same count of rows as A
	///		<see cref="num.real.vecs.to_._GramMatrixX"/>
	static public class _EndoMultiplyX
	{

		/// <summary>
		/// A*A^T;
		/// 
		/// A^T A can be derived by replacing 'A' with 'A^T'
		/// </summary>
		/// <remarks>
		///  this is considered more canonical than <see cref="TransposeMul(quotient_.DenomNonnil[,])"/> in that A A^T  has same rows as A;
		/// </remarks>
		/// <param name="a"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] MulTranspose(Q[,] a) {
			return matrix.bi_._MultiX._Multiply_1sociable(
				a
				,
				op_.Transpose.Op(a)
			);
		}



	}
}
