using nilnul.obj.matrix.co.be_.multible.vow;
using nilnul.obj.str;
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


namespace nilnul.num.real.expr_.polynom.matrix_.isosize.bi_.add
{
	/// <see cref="nilnul.obj.matrix_.isosize.bi"/>
	/// <summary>
	/// </summary>
	/// <see cref="matrix.co_.plusable._PlusX"/>
	static public class _CumulaX
	{
		public static void _Add_1isosize(ref T[,] a, params IEnumerable< T[,]> b)
		{
			foreach (var item in b)
			{
				bi_._AddX._Add_1equisize(ref a, item);
			}
		}

	

		public static T[,]  _Plus_1isosizeStud(IEnumerable< T[,]> b)
		{
			var cloned = b.First().Clone() as T[,];
			_Add_1isosize(ref cloned, b.Skip(1));
			return cloned;
		}

		public static T[,]  _Plus_1isosize(this Q4[,] a, IEnumerable< T[,]> b)
		{
			var o = nilnul.num.real.expr_.polynom.matrix._OfX.ToPolynomials(a);
			_Add_1isosize(ref o, b);
			return o;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void  _Add_1isosize(ref T[,] a,IEnumerable< Q4[,]> b)
		{
			_Add_1isosize(ref a, 
b.Select(x=>nilnul.num.real.expr_.polynom.matrix._OfX.ToPolynomials(x)));
		}

		public static T[,]  _Plus_1isosize(this T[,] a, IEnumerable< Q4[,]> b)
		{
			var o = (T[,]) (a.Clone());
			_Add_1isosize(ref o, b);
			return o;
		}

	}
}
