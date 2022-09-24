using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.co.sociable
{
	[Obsolete(nameof(co_))]
	static public  class ProductX
	{
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

		public static double[] Multiply(this double[,] a, double[] b)
		{

			double[] c = new double[a.Length];//every element has been initialized to 0.


			for (int i1 = 0; i1 < c.GetLength(0); i1++)
			{
				
				c[i1] += nilnul.num.real.str.duo.sameLen.Multi._Eval(
					a,i1,b
				);

				
				
			}

			return c;

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
