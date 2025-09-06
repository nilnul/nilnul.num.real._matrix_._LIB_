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

namespace nilnul.num.real.matrix_.sq.to_.scalar_
{

	public static class _DeterminantX
	{
		static public double _Determinant_assumeSquare(
			double[,] square
		)
		{
			var width = square.GetLength(0);
			if ( width == 0)
			{
				return 1;
			}

			return Enumerable.Range(0, width).AsParallel().Select(
				i=> cel.remnant.minor._CofactorX._AssumeValid(
					square,  0,i
				)*square[0,i]
			).Sum()
			//	.Aggregate(
			//	(a,c) => a+c
			//)
				;
		}

		static public R3 Determinant(
			nilnul.num.real.matrix_.Square1 square
		)
		{
			if (square.dimension.beZero)
			{
				return new Qr(1);

			}
			R3 r = new Qr(0);
			for (int i = 0; checked((uint)i) < square.dimension.cols; i++)
			{

				r = nilnul.num.real.op_.binary_.Add.Singleton.op(r, nilnul.num.real.op_.binary_.Multi.Singleton.op(square.val[0, i], Cofactor.Eval(square, 0, i))
					)
				;
			}
			return r;

		}

		static public R2 Determinant(
			nilnul.num.real.matrix_.Square2 square
			)
		{
			if (square.dimension.beZero)
			{
				return new Qr(1);

			}
			R3 r = new Qr(0);
			for (int i = 0; checked((uint)i) < square.dimension.cols; i++)
			{

				r = nilnul.num.real.op_.binary_.Add.Singleton.op(r, nilnul.num.real.op_.binary_.Multi.Singleton.op(square.val[0, i], Cofactor.Eval(square, 0, i))
					)
				;
			}
			return  R2.Ov(r);

		}
		public static nilnul.num.RealI Determinant(R3[,] r)
		{
			return Determinant(new Square2(r));
		}

		internal static nilnul.num.RealI Determinant(BigInteger[,] m)
		{
			var r = nilnul.num.real.matrix.of_._OfIntegersX.OfIntegers(m);
			return Determinant( r);
		}

	}//class
}
