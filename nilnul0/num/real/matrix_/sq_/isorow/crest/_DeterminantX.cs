using nilnul.num.real.expr_;
using nilnul.num.real.expr_._algebraic;
using nilnul.num.real.expr_.polynom.matrix_.sq;
using nilnul.obj.str;
using nilnul.obj.stream_.slider.to_;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using P = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.matrix_.sq_.isorow.crest
{
	static public class _DeterminantX
	{
		static public Q4 _ToDeterminant_0row_1crest(Q4[] row, Q4 crest)
		{
#if DEBUG

			var m = _CrestX.Generate(row, crest);

			var n = row.Length;

			/// add all cols to the first col:
			/// 
			for (int j = 0; j < n; j++)
			{
				for (int i = 0; i<n; i++)
				{
					m[i, 0] +=m[i, j];

				}
			}
			/// the cel in col[0]: sum(a[i]) +c
			/// 


			Contract.Assert(
				nilnul.num.quotient.Eq2.Singleton.Equals(
					m[0, 0], row.Aggregate(Q4.Nil, (a, c) => a+c) + crest
				)
			);


			/// each nonfirst row minus the first row:
			/// 
			for (int i = 1; i<n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					m[i, j] -=m[0, j];

				}
			}

			/// the result is upper triag
			/// 
			Contract.Assert(
				nilnul.num.real.matrix_.sq.be_.triag_._UpperX._IsUpper_0fair(m)
			);

			/// the determ is :

			var determ = nilnul.num.real.matrix_.sq_.triag._DeterminantX._Determinant_0triag(m);
#endif
			var wide = row.Length;
			///the inferred ans , 
			return wide==0?1: (
				row.Aggregate(
					Q4.Nil, (a, c) => a+c
				) 
				+crest
			) 
			*
			num.quotient.op_._PonentX._Quotient_1natural(
					crest
					,
					wide-1
			);
			/// <see cref="unival.crest._DeterminantX"/>
		}
	}
}