using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square.solo.op
{
	[Obsolete(nameof(Adjugate) + "; classic adjoint means adjugate, but later adjoint means sth in linear mapping")]
	static public class AdjointX
	{
		public static double[,] _Adjoint(this double[,] matrix_square)
		{

			//it has to be square

			int n = matrix_square.GetLength(0);

			


			double[,] r = new double[n,n];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					r[i, j] = Cofactor.Eval(matrix_square,j, i);
				}
			}
			return r;

		}

	}
}
