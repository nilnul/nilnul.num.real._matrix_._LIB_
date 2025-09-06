using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square
{
	/// <summary>
	/// cofactor matrix
	/// </summary>
	///
	[Obsolete(nameof(Adjugate)+ @"; classic adjoint means adjugate, but later adjoint means sth in linear mapping

In mathematics, specifically in operator theory, each linear operator A on a Euclidean vector space defines a Hermitian adjoint (or adjoint) operator A^{*} on that space according to the rule

en.wikipedia.org/wiki/Hermitian_adjoint

" +
		"" +
		"")]
	static public partial class AdjointX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix_notNull"></param>
		/// <returns></returns>
		public static double[,] _Eval(this double[,] matrix_notNull)
		{
			
			Square.AssertionOfDouble.assert(matrix_notNull);


			return _Eval_notNull_square(matrix_notNull);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix_notNull_square"></param>
		/// <returns></returns>
		public static double[,] _Eval_notNull_square(this double[,] matrix_notNull_square)
		{ 
			 
			//it has to be square

			int n = matrix_notNull_square.GetLength(0);



			double[,] r = new double[n, n];

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = matrix_notNull_square.AlgebraicCofactor(j, i);
				}
			}
			return r;

		}



	}
}
