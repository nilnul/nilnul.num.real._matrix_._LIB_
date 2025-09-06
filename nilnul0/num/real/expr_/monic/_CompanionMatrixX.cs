using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.monic
{
	/// <summary>
	/// en.wikipedia.org/wiki/Companion_matrix
	/// </summary>
	static public class _CompanionMatrixX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="coefficients">
		/// except the highest coef which is 1.
		/// </param>
		/// <returns></returns>
		static public double[,] CompanionMatrix_0coefsBeforeHighest(double[] coefficients)
		{
			///degree

			int degree = coefficients.Length;


			var r = new double[degree, degree];

			int degreeMinus = degree - 1;

			r[0, degreeMinus] = -coefficients[0] ;

			for (int i = 1, j=0; i < degree; i++, j++)
			{
				r[i, j] = 1 ;

				r[i, degreeMinus] = -coefficients[ i] ;


			}

			return r;


		}
	}
}
