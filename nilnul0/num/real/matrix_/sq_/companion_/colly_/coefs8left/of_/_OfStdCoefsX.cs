using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.companion_.colly_.coefs8left.of_
{
	/// <summary>
	/// note for std coefs, the highest degree coef is 1; so if the coefs is empty, then the polynom is 1*x^0, and the matrix is empty.
	/// </summary>
	static public class _OfStdCoefsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="coefs"></param>
		/// <returns>
		/// if a = this of [a0,a1,...a[n] ] 
		/// , b = <see cref="coefs8right"/> of [b0,b1,...b[n] ]
		/// , then:
		///		a.Reverse() = [b1,..., b[n], 1] / b0 
		/// </returns>
		static public Q4[,] _OfStdCoefs(
			Q4[] coefs
		)
		{

			var c = coefs.Length;
			if (c==0)
			{
				return new quotient_.DenomNonnil[0, 0];
			}

			/// 	 eg:
			///		[
			///			-c1/c0,		1,0,...,	0
			///			-c2/c0,		0,1,...		0
			///			-c3/c0,		0,0,...		0
			///			...
			///			-c[n-1]/c0,	0,0,...,	1
			///			-1/c0,		0,0,...		0
			///		]
			///		, note here the intercept of the polynomial is at the bottom left corner.


			var o = nilnul.num.real.matrix_.sq_._NilX.Generate8quotient(c);

			var coefs0 = coefs[0];
			var degreeMinus = c - 1;

			for (int i = 0, j = 1; j < c; i++, j++)
			{
				o[i, j] = 1; /// supdiag is 1

				o[i, 0] =-coefs[degreeMinus-i];		/// 1st col 

			}
			o[degreeMinus, 0] = -coefs[0];

			return o;

		}


	}
}
