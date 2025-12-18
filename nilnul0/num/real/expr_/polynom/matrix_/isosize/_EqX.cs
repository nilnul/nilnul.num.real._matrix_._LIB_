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


namespace nilnul.num.real.expr_.polynom.matrix_.isosize
{
	/// <summary>
	/// </summary>
	static public class _EqX
	{
		public static bool _Eq_1isosize(this T[,] a, T[,] b)
		{
			int height = a.GetLength(0);
				int width = a.GetLength(1);

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if (a[i, j]!=b[i,j])
					{
						return false;
					}
				}

			}
			return true;
		}

	}
}
