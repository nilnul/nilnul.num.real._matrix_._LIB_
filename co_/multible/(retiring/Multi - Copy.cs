using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;


namespace nilnul.num.real.matrix.duo_.sociable
{
	[Obsolete(nameof(matrix.co_))]
	static public class Multi
	{

		public static R2[,] Multiply(this R2[,] a, R2[,] b)
		{

			var c = new R2[a.GetLength(0), b.GetLength(1)];//every element has been initialized to 0.


			for (int i1 = 0; i1 < c.GetLength(0); i1++)
			{

				for (int j = 0; j < c.GetLength(1); j++)
				{
					c[i1, j] =  new R2(nilnul.num.real.str.co_.sameLen._MultiX._Multi_ofTwoSameLengthStr(
						nilnul.collection.matrix.MatrixX.Row(
						a, i1).Select(x=>x.boxed)
						, 
						nilnul.collection.matrix.MatrixX.Column(
						b, j).Select(x=>x.boxed)
					));

				}

			}

			return c;

		}

		/// <summary>
		/// a horizontal vector times a matrix.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[] Multiply(this double[] a, double[,] b)
		{

			double[] c = new double[b.GetLength(1)];//every element has been initialized to 0.


			for (uint j = 0; j < c.Length; j++)
			{

				for (uint i = 0; i < b.GetLength(0); i++)
				{
					c[j] += a[i] * b[i, j];
				}
			}

			return c;

		}

		public static double[,] Multiply(this double[,] a, double[,] b)
		{

			double[,] c = new double[a.GetLength(0), b.GetLength(1)];//every element has been initialized to 0.


			for (int i1 = 0; i1 < c.GetLength(0); i1++)
			{

				for (int j = 0; j < c.GetLength(1); j++)
				{
					c[i1,j] += nilnul.num.real.str.duo.sameLen.Multi._Eval(
						a,i1,b,j
					);

				}
				
			}

			return c;

		}

		public static double[] _Multiply(this double[,] a, double[] _b_lengthEqAWidth)
		{

			double[] r = new double[_b_lengthEqAWidth.Length];//every element has been initialized to 0.


			for (int i1 = 0; i1 < r.GetLength(0); i1++)
			{
				
				r[i1] += nilnul.num.real.str.duo.sameLen.Multi._Eval(
					a,i1,_b_lengthEqAWidth
				);

				
				
			}

			return r;

		}

		public static float[] Multiply(this float[,] a, float[] b)
		{

			float[] c = new float[a.Length];//every element has been initialized to 0.


			for (int i1 = 0; i1 < c.GetLength(0); i1++)
			{
				
				c[i1] += nilnul.num.real.str.duo.sameLen.Multi._Eval(
					a,i1,b
				);

				
				
			}

			return c;

		}




	}
}
