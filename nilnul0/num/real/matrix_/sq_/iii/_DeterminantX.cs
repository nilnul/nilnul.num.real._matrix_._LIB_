using nilnul.num.real.matrix.square;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using nilnul.num.real.matrix;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R3 = nilnul.num.RealI;
using R2 = nilnul.num.Real;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.iii
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// the signed volume
	/// </remarks>
	public static class _DeterminantX
	{
		/// <summary>
		/// In matrix theory, the rule of Sarrus is a mnemonic device for computing the determinant of a 3¡Á3 matrix named after the French mathematician Pierre Fr¨¦d¨¦ric Sarrus.
		/// </summary>
		/// <param name="square"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _Determinant_0iii(
			double[,] square
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q _Determinant_0iii(
			Q[,] square
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


	}//class
}
