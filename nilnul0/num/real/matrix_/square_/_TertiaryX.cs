using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;

namespace nilnul.num.real.matrix_.square_
{
	static public class _TertiaryX
	{
		static public R[,] Of(
			R a, R b, R c
			,
			R d,R e,R f
			,
			R g, R h, R i
		)
		{

			return new double[,] { { a, b ,c  }, { d,e,f }, { g,h,i} }
			;
		}

		static public R Determinant(

			R a, R b, R c
			,
			R d,R e,R f
			,
			R g, R h, R i

		) {
			return real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
				Of(
					a,b,c
					,
					d,e,f
					,
					g,h,i
				)
			);
		}

	}
}
