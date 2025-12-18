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


namespace nilnul.num.real.expr_.polynom.matrix
{
	/// <summary>
	/// </summary>
	/// <see cref="matrix.co_.plusable._PlusX"/>
	static public class _EqX
	{
		public static bool Eq(this T[,] a, T[,] b)
		{
			return nilnul.obj.matrix.re_._PlusibleX.Re(a, b) && matrix_.isosize._EqX._Eq_1isosize(a, b);
	
		}
	}

	public class Eq : 
		nilnul.obj.matrix.Eq<T>
	{

	}
}
