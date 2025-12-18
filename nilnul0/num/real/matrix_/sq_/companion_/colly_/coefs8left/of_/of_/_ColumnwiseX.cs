using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.companion_.colly_.left.of_
{
	/// en.wikipedia.org/wiki/Companion_matrix
	/// <summary>
	/// from <see cref="real.matrix_.sq._eigen.Polynomial"/>
	/// </summary>
	/// <see cref="real.matrix_.sq._eigen.polynom.ICompanion"/>
	/// <see cref="real.expr_.polynom.matrix_.sq_.companion_._RowwiseX"/>
	static public class _CoefsX
	{
		/// <summary>
		/// eg:
		///		[
		///			-c0,		1,0,0,...,	0
		///			-c1,		0,1,0,...	0
		///			-c2,		0,0,1,...	0
		///			...
		///			-c[n-1],	0,0,0,...	0	
		///		]
		///	,for:
		///		c0 + c1 x + c2 x^2 +... c[n-1]x^(n-1) + x^n
		/// </summary>
		/// <remarks>
		///  the coef of the highest term is implied as 1. <see cref="real.expr_.polynom_.univar_.std_.xpn_.INil"/>
		///  ;
		///  1 => []
		///  ;
		///  x+a0 =>	[
		///			-a0
		///		]
		///  
		/// </remarks>
		/// <param name="coefficients">
		/// except the highest coef which is 1.
		/// </param>
		/// <returns></returns>
		static public Q4[,] CompanionMatrix_0coefsBeforeHighest(Q4[] coefficients)
		{
			///degree

			int degree = coefficients.Length;


			var r = new Q4[degree, degree];

			int degreeMinus = degree - 1;

			r[0, degreeMinus] = -coefficients[0] ;

			for (int i = 1, j=0; i < degree; i++, j++)
			{
				r[i, j] = 1 ; /// subdiag is 1

				r[i, degreeMinus] = -coefficients[ i] ; /// last col is -coef


			}

			return r;


		}
	}
}
