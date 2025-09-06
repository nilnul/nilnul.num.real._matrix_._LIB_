using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R3 = System.Double;

namespace nilnul.num.real.matrix_.sq_
{
	static public class _TertiaryX
	{
		static public R3[,] Of(
			R3 a, R3 b, R3 c
			,
			R3 d,R3 e,R3 f
			,
			R3 g, R3 h, R3 i
		)
		{

			return new double[,] { { a, b ,c  }, { d,e,f }, { g,h,i} }
			;
		}

		static public R3 Determinant(

			R3 a, R3 b, R3 c
			,
			R3 d,R3 e,R3 f
			,
			R3 g, R3 h, R3 i

		) {
			return real.matrix_.sq.to_.scalar_._DeterminantX._Determinant_assumeSquare(
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
