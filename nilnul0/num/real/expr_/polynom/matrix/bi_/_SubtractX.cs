using nilnul.obj.matrix.co.be_.multible.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
//using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;
using T = nilnul.num.real.expr_.Algebraic;


namespace nilnul.num.real.expr_.polynom.matrix.bi_
{
	/// <summary>
	/// throw exception if the two args are not isosize.
	/// </summary>
	/// <see cref="matrix.co_.plusable._PlusX"/>
	static public class _SubtractX
	{
		public static void _Deduce_1equisize(this T[,] a, T[,] b)
		{
			int height = a.GetLength(0);
				int width = a.GetLength(1);

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					a[i, j] -= b[i, j];
				}

			}
		}


		public static T[,]  _Minus_1equisize(this Q4[,] a, T[,] b)
		{

			var o = nilnul.num.real.expr_.polynom.matrix._OfX.ToPolynomials(a);

			

			_Deduce_1equisize( o, b);
			return o;

		}
		public static T[,]  _Minus_1equisize(this T[,] a, T[,] b)
		{

			var cloned = a.Clone() as T[,];

			_Deduce_1equisize(cloned, b);
			return cloned;

		}
	


	}
}
