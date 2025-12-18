using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.companion_.colly_.invertible.op_
{
	static public class _InvertX
	{
		static public Q4[,] _Invert_0coefs(
			Q4[] coefs
		)
		{

			var c = coefs.Length;
			if (c==0)
			{
				return new quotient_.DenomNonnil[0, 0];
			}


			/// input:
			/// 	 eg:
			///		[
			///			0,0,0,...,	0,	 -c0
			///			1,0,0,...	0,	-c1
			///			0,1,0,...	0,	-c2
			///			...
			///			0,0,0,...	1,	-c[n-1]
			///		]


			/// output:
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

			for (int i = 0, j = 1; j < c; i++, j++)
			{
				o[i, j] = 1; /// supdiag is 1

				o[i, 0] = -coefs[j] / coefs0; /// 1st col 

			}
			o[c - 1, 0] = -1/coefs0;
					///<see cref="companion_.colly_.coefs8left.of_._OfStdCoefsX"/>

			return o;

		}
	}
}
