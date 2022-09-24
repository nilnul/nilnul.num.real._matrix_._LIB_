using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;


namespace nilnul.num.real.matrix.co_.plusable
{
	static public class _PlusX
	{

		public static void _Add2self_assumePlusable(this double[,] a, double[,] b)
		{

			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] += b[i, j];

				}

			}

		}
		public static Matrix4dbl Add(nilnul.obj.matrix.co.be_.plusable.vow.Ee<double> b)
		{
			return _Add_assumePlusable(b.eeByRef.Item1,b.eeByRef.Item2);
		}

		public static Matrix4dbl Add(Matrix4dbl a, Matrix4dbl b)
		{
			return Add(
				new obj.matrix.co.be_.plusable.vow.Ee<double>( a, b)
			);
		}


		/// <summary>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[,] _Add_assumePlusable(this double[,] a, double[,] b)
		{
			var r = (double[,]) ( a.Clone() );

			_PlusX._Add2self_assumePlusable(r, b);
			return r;
			
		}
		public static void _SubtractFroSelf_assumePlusable(this double[,] a, double[,] b)
		{

			 _Add2self_assumePlusable(a, num.real.matrix.op_.unary_._NegX.NegateAsNew(b));

		}
		/// <summary>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[,] _Subtract_assumePlusable(this double[,] a, double[,] b)
		{
			var r = (double[,]) ( a.Clone() );

			_PlusX._SubtractFroSelf_assumePlusable(r, b);
			return r;
			

		}

	


	}
}
