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

namespace nilnul.num.real.matrix_.sq._determ_.by_
{
	[Obsolete(nameof(_BySubmatrixX) + " is preferred as this is slower")]
	public static class _ByRegenerateX
	{
		static public double _Determinant_0equilat(
			double[,] square
		)
		{
			var width = square.GetLength(0);
			switch (width)
			{
				case 0:
					return 1;
				case 1:
					return square[0, 0];
				case 2:
					return square[0, 0] * square[1, 1] -square[0, 1] * square[1, 0];
				case 3:
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
				/// todo: width =4

				//default:

				//	break;

			}

			return Enumerable.Range(0, width).AsParallel().Select(
				i => matrix_.sq.cel.remnant.minor._CofactorX._AssumeValid(
					square, 0, i
				)*square[0, i]
			).Sum()
				//	.Aggregate(
				//	(a,c) => a+c
				//)
				;
		}

		static public Q _Determinant_0equilat(
			Q[,] square
		)
		{
			var width = square.GetLength(0);

			switch (width)
			{
				case 0:
					return 1;
				case 1:
					return square[0, 0];
				case 2:
					return square[0, 0] * square[1, 1] -square[0, 1] * square[1, 0];
				case 3:
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
				/// todo: width =4

				//default:

				//	break;

			}

			return Enumerable.Range(0, width).AsParallel().Select(
				i => cel.remnant.minor._CofactorX._AssumeValid(
					square, 0, i
				)*square[0, i]
			)
				.Aggregate(
				(a, c) => a + c
			)
			;

		}


	}//class
}
