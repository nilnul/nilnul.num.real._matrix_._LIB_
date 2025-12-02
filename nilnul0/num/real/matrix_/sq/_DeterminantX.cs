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

namespace nilnul.num.real.matrix_.sq
{

	public static class _DeterminantX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _Determinant_0sq(
			double[,] square
		)
		{
			return _determ_.by_._ByPermuteX._Determ_0sq(square);
			//return _determ_.by_._BySubmatrixX._Determinant_0sq(square);
	
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q _Determinant_0sq(
			ref Q[,] square
		)
		{
			return num.quotient.matrix_.sq._DeterminantX._Determinant_0sq(ref square);

			//return _determ_.by_._BySubmatrixX._Determinant_0sq(square);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q _Determinant_0sq(
			Q[,] square
		)
		{
			return num.quotient.matrix_.sq._DeterminantX._Determinant_0sq(square);

			//return _determ_.by_._BySubmatrixX._Determinant_0sq(square);
		}

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q _Determinant_0sq(
			int[,] square
		)
		{
			Q4[,] square1 = nilnul.num.quotient.matrix.of_._OfIntegersX.OfIntegers(square);

			return _Determinant_0sq(
				ref square1
			);

			//return _determ_.by_._BySubmatrixX._Determinant_0sq(square);
		}


	}
}
