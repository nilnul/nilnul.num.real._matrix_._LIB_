using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.num.real.expr_._algebraic;
using nilnul.obj.stream_.slider.to_;
using nilnul.num.real.expr_.polynom.matrix_.sq;
using nilnul.obj.str;
using nilnul.num.real.expr_;
using P = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.matrix_.sq_.unival.crest
{
	static public class _DeterminantX
	{
		static public Q4 Determinant(
			int wide, Q4 unival, Q4 crest
		)
		{

#if DEBUG

			var m = _CrestX.Generate(wide, unival, crest);

			/// now the matrix is unival(a) +diag(x)

			/// all coles summed as the col0:
			/// 

			for (int i = 0; i < wide; i++)
			{
				for (int j = 1; j < wide; j++)
				{
					m[i, 0] +=m[i, j];
				}
			}
			/// [
			///		a*n+x,	a,		a,...,	a,		a
			///		a*n+x,	a+x,	a,		a,		a
			///		a*n+x,	a,		a+x,	...,	a
			///		...
			///		a*n+x,	a,		a		...		a+x
			///		
			/// ]

			/// each row minuses the first row:
			/// 

			for (int i = 1; i < wide; i++)
			{
				for (int j = 0; j < wide; j++)
				{
					m[i, j] -= m[i-1, j];
				}

			}

			/// [
			///		a*n+x,	a,		a,...,	a,		a
			///		0,		x,		a,		a,		a
			///		0,		0,		x,	...,		a
			///		...
			///		0,		0,		0		...		x
			///		
			/// ]
			///
			/// => (a*n +x) x**(n-1)
			/// 

#endif

			return wide==0 ? 1 : (unival*wide + crest) * nilnul.num.quotient.op_._PonentX._Quotient_1natural(crest, wide-1);

			///<see cref="num.real.matrix_.sq_.isorow.crest._DeterminantX"/>

		}
	}
}