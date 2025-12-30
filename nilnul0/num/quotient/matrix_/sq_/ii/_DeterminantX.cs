using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R3 = System.Double;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R2 = nilnul.num.Real;
using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix_.sq_.ii
{
	/// <summary>
	/// aka: 2x2
	/// </summary>
	/// <remarks>
	/// it's the signed area (surrounded);
	/// </remarks>
	static public class _DeterminantX
	{


		/// <summary>
		/// note tranposed.determinant is the same, so it doesnot matter the input is rowwise or colwise.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="a1"></param>
		/// <param name="b1"></param>
		/// <returns></returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 Determinant(Q4 a, Q4 b, Q4 a1, Q4 b1 ) {
			return a * b1 - b * a1;
			//return square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
			//	new double[,] { { a, b }, { c, d } }
			//) ;
		}





	}
}
