using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R3 = nilnul.num.RealI;
using R2 = nilnul.num.Real;


namespace nilnul.num.real.matrix.co_.equisize
{
	/// <summary>
	/// <see cref="nilnul.num.real.co.IDifference"/>
	/// <see cref="nilnul.num.real.bi_.dif_.IMinus"/>
	/// </summary>
	static public class _DeductX
	{

		public static void _SubtractFroSelf_1equisize(this double[,] a, double[,] b)
		{


			int rows = a.GetLength(0);
			int cols = a.GetLength(1);

			for (int i = 0; i < rows; i++)
			{

				for (int j = 0; j < cols; j++)
				{
					a[i, j] -= b[i, j];

				}

			}

		}

		public static void _SubtractFroSelf_1equisize(this Q[,] a, Q[,] b)
		{

			int rows = a.GetLength(0);
			int cols = a.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					a[i, j] -= b[i, j];
				}
			}
		}

		/// <summary>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[,] _Subtract_1equisize(this double[,] a, double[,] b)
		{
			var r = (double[,])(a.Clone());

			_SubtractFroSelf_1equisize(r, b);
			return r;

		}

		public static Matrix4dbl Subtract(nilnul.obj.matrix.co.be_.plusable.vow.Ee<double> b)
		{
			return _Subtract_1equisize(b.eeByRef.Item1, b.eeByRef.Item2);
		}

		public static Matrix4dbl Subtract(Matrix4dbl a, Matrix4dbl b)
		{
			return Subtract(
				new obj.matrix.co.be_.plusable.vow.Ee<double>(a, b)
			);
		}



		public static Q[,] _Subtract_1equisize(this Q[,] a, Q[,] b)
		{
			var r = (Q[,])(a.Clone());

			_SubtractFroSelf_1equisize(r, b);
			return r;

		}





	}
}
