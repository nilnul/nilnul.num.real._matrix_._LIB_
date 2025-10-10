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


namespace nilnul.num.real.matrix.bi_.mul.at_
{
	/// <summary>
	/// </summary>
	/// alias:
	///		outer product
	static public class _ColRowX
	{


		/// <summary>
		/// a horizontal vector times a matrix.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[,] Multiply(this double[] a, double[] b)
		{
			int rows = a.Length;
			int cols = b.Length;
			double[,] c = new double[rows,cols];

			for (int i0 = 0; i0 < rows; i0++)
			{
				for (int j = 0; j < cols; j++)
				{
					c[i0,j] = a[i0] * b[j];
				}
			}
			return c;
		}

		public static int[,] Multiply(this int[] a, int[] b)
		{
			int rows = a.Length;
			int cols = b.Length;
			var c = new int[rows,cols];

			for (int i0 = 0; i0 < rows; i0++)
			{
				for (int j = 0; j < cols; j++)
				{
					c[i0,j] = a[i0] * b[j];
				}
			}
			return c;
		}

		public static Q[,] Multiply(this Q[] a, Q[] b)
		{
			int rows = a.Length;
			int cols = b.Length;
			var c = new Q[rows,cols];

			for (int i0 = 0; i0 < rows; i0++)
			{
				for (int j = 0; j < cols; j++)
				{
					c[i0,j] = a[i0] * b[j];
				}
			}
			return c;
		}






	}
}
