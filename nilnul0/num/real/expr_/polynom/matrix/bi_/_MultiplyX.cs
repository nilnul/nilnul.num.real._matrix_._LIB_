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
	/// throw exception if the two args are not mutipliable.
	/// </summary>
	/// <see cref="matrix.co_.plusable._PlusX"/>
	static public class _MultiplyX
	{
		public static T[,] _Multiply_1chainable(this T[,] a, T[,] b)
		{
			int height = a.GetLength(0);
			int width = a.GetLength(1);
			var o = new T[height, width];


			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					o[i, j] = nilnul.num.real.expr_.polynom.vec.co._SumOfProductX._Sop_1equisize(
						nilnul.obj.matrix._RowsX.Row(a, i)
						,
						obj.matrix._ColsX.Col(b, j)
					);
				}
			}
			return o;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T[,] _Multiply_1chainable(this Q4[,] a, T[,] b)
		{
			return _Multiply_1chainable(nilnul.num.real.expr_.polynom.matrix._OfX.ToPolynomials(a), b);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T[,] _Multiply_1chainable(this T[,] a, Q4[,] b)
		{
			return _Multiply_1chainable(a, nilnul.num.real.expr_.polynom.matrix._OfX.ToPolynomials(b));
		}



	}
}
