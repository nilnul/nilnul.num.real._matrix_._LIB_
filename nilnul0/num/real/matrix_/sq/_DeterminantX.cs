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

namespace nilnul.num.real.matrix_.sq
{

	public static class _DeterminantX
	{
		static public double _Determinant_0square(
			double[,] square
		)
		{
			var width = square.GetLength(0);
			if ( width == 0)
			{
				return 1;
			}

			return Enumerable.Range(0, width).AsParallel().Select(
				i=> matrix_.sq. cel.remnant.minor._CofactorX._AssumeValid(
					square,  0,i
				)*square[0,i]
			).Sum()
			//	.Aggregate(
			//	(a,c) => a+c
			//)
				;
		}

		static public Q _Determinant_0square(
			Q[,] square
		)
		{
			var width = square.GetLength(0);
			if ( width == 0)
			{
				return 1;
			}

			return Enumerable.Range(0, width).AsParallel().Select(
				i=> matrix_.sq. cel.remnant.minor._CofactorX._AssumeValid(
					square,  0,i
				)*square[0,i]
			)
				.Aggregate(
				(a, c) => a + c
			)
				;
		}


	}//class
}
