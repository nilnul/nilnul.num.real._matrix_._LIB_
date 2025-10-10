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


namespace nilnul.num.real.matrix.bi_
{
	/// <summary>
	/// throw exception if the two args are not isosize.
	/// </summary>
	/// <see cref="matrix.co_.plusable._PlusX"/>
	static public class _SubtractX
	{
		public static void _Deduce_1equisize(this double[,] a, double[,] b)
		{
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] -= b[i, j];
				}

			}
		}
		public static void _Deduce_1equisize(this int[,] a, int[,] b)
		{
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] -= b[i, j];
				}

			}
		}

		public static void _Deduce_1equisize(this Q[,] a, Q[,] b)
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


	


		//public static void _Deduce_1equisize(this R[,] a, R[,] b)
		//{
		//	for (int i = 0; i < a.GetLength(0); i++)
		//	{
		//		for (int j = 0; j < a.GetLength(1); j++)
		//		{
		//			a[i, j] = nilnul.num.real.bi_._MinusX.Minus(
		//				a[i, j]
		//				,
		//				b[i, j]

		//			);
		//		}

		//	}
		//}

		//public static R[,]  _Add_1isosize(this R[,] a, R[,] b)
		//{

		//	var cloned = a.Clone() as R[,];

		//	_Deduce_1equisize(cloned, b);
		//	return cloned;

		//}

		public static int[,]  _Minus_1equisize(this int[,] a, int[,] b)
		{

			var cloned = a.Clone() as int[,];

			_Deduce_1equisize(cloned, b);
			return cloned;

		}
		public static double[,]  _Minus_1equisize(this double[,] a, double[,] b)
		{

			var cloned = a.Clone() as double[,];

			_Deduce_1equisize(cloned, b);
			return cloned;

		}

		public static Q[,]  _Minus_1equisize(this Q[,] a, Q[,] b)
		{
			var cloned = a.Clone() as Q[,];

			_Deduce_1equisize(cloned, b);
			return cloned;

		}

	




	}
}
