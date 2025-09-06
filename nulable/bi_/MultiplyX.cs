using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.nulable.op_.binary_
{
	static public  class _MultiplyX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		/// <exception cref="">when null or nonmultible</exception>
		public static double[,] MultiAsNonnulable(this double[,] a, double[,] b)
		{

			if (a==null || b==null)
			{
				throw new ArgumentNullException();
			}


			//if (a==null )
			//{
			//	a = new double[0, 0];

			//}
			//if (b==null)
			//{
			//	b = new double[0, 0];
				
			//}

			///
			var gageLen = a.GetLength(1);

			if (gageLen != b.GetLength(0))
			{
				throw new Exception("a.N!=b.M.");

			}

			return num.real.matrix.co_.multible._MultiX._Multiply_assumeSociable(
				a,b
			);


			//double[,] c = new double[a.GetLength(0), b.GetLength(1)];

			//for (int i = 0; i < c.GetLength(0); i++)
			//{
			//	for (int j = 0; j < c.GetLength(1); j++)
			//	{

			//		for (int k = 0; k < gageLen; k++)
			//		{
			//			c[i, j] += a[i, k] * b[k, j];

			//		}

			//	}

			//}
			//return c;


		}


	
	}
}
