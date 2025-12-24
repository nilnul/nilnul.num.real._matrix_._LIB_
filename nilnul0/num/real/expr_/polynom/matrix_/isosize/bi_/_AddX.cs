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


namespace nilnul.num.real.expr_.polynom.matrix_.isosize.bi_
{
	/// <summary>
	/// </summary>
	/// <see cref="matrix.co_.plusable._PlusX"/>
	static public class _AddX
	{
		public static void _Add_1equisize(ref T[,] a, T[,] b)
		{
			int height = a.GetLength(0);
			int width = a.GetLength(1);

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					a[i, j] += b[i, j];
				}

			}
		}

		public static T[,]  _Plus_1equisize(this T[,] a, T[,] b)
		{
			var cloned = a.Clone() as T[,];
			_Add_1equisize(ref cloned, b);
			return cloned;
		}

		public static T[,]  _Plus_1equisize(this Q4[,] a, T[,] b)
		{
			var o = nilnul.num.real.expr_.polynom.matrix._OfX.ToPolynomials(a);
			_Add_1equisize(ref o, b);
			return o;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void  _Add_1equisize(ref T[,] a, Q4[,] b)
		{
			_Add_1equisize(ref a, nilnul.num.real.expr_.polynom.matrix._OfX.ToPolynomials(b));
		}

		public static T[,]  _Plus_1equisize(this T[,] a, Q4[,] b)
		{
			var o = (T[,]) (a.Clone());
			_Add_1equisize(ref o, b);
			return o;
		}

	}
}
