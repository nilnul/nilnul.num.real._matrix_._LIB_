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


namespace nilnul.num.real.matrix_.sq.bi_.add_
{
	/// <summary>
	/// A + kI
	/// </summary>
	/// alias:
	///		scala
	static public class _RidgeX
	{
		public static void _Augment_0equilat(this Q[,] a, Q b)
		{
			int rows = a.GetLength(0);

			for (int i = 0; i < rows; i++)
			{
					a[i, i] += b;

			}
		}


		public static Q[,] _Add_0equilat(this Q[,] a, Q b)
		{
			var r= a.Clone() as Q[,];
			_Augment_0equilat(r, b);
			return r;

		}




	


	}
}
