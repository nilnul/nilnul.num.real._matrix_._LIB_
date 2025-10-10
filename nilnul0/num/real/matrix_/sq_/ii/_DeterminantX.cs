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

namespace nilnul.num.real.matrix_.sq_.ii
{
	/// <summary>
	/// aka: 2x2
	/// </summary>
	static public class _DeterminantX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public R3 Determinant(R3 a, R3 b, R3 a1, R3 b1 ) {
			return a * b1 - b * a1;
			//return square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
			//	new double[,] { { a, b }, { c, d } }
			//) ;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q Determinant(Q a, Q b, Q a1, Q b1 ) {
			return a * b1 - b * a1;
			//return square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
			//	new double[,] { { a, b }, { c, d } }
			//) ;
		}





	}
}
