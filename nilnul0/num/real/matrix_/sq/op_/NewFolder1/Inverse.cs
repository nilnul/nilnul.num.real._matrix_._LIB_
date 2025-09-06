using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square.solo.op
{
	public partial class Inverse
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns>
		/// empty if empty.
		/// </returns>
		public static double[,] _Eval( double[,] matrix)
		{


			//if (determ == 0)
			//{
			//	throw new Exception("The determinant of the matrix is 0 so it's not inversible.");
			//}

		

			return (1.0 / Determinant._Eval(matrix)).Multiply(Adjugate.Eval(matrix));

			




		}


	}
}
