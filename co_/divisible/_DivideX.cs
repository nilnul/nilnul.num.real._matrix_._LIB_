using nilnul.num.real.matrix.co_.multible;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;


namespace nilnul.num.real.matrix.co_.divisible
{
	static public class _DivideX
	{

		public static double[,] _Divide_assumeDivisable(this double[,] a, double[,] b)
		{
			return a._Multiply_assumeSociable(
				b.Inverse()
			);

		}

	



	}
}
