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

namespace nilnul.num.quotient.matrix_.sq_.iii
{
	/// <summary>
	/// aka: 3*3
	/// </summary>
	/// <remarks>
	/// it's the signed area (surrounded);
	/// </remarks>
	/// <see cref="num.real.matrix_.sq_.iii._DeterminantX"/>
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
		static public Q4 _Determinant_0iii(
			Q4[,] square
		)
		{

			return square[0, 0] * square[1, 1]* square[2, 2]
				+
				square[0, 1] * square[1, 2]* square[2, 0]
				+
				square[0, 2] * square[1, 0]* square[2, 1]

				-
				square[0, 2] * square[1, 1]* square[2, 0]
				-
				square[0, 1] * square[1, 0]* square[2, 2]
				-
				square[0, 0] * square[1, 2]* square[2, 1]
			;


		}



	}
}
