using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.num.real.expr_._algebraic;
using nilnul.obj.stream_.slider.to_;
using nilnul.num.real.expr_.polynom.matrix_.sq;
using nilnul.obj.str;
using nilnul.num.real.expr_;
using P = nilnul.num.real.expr_.Algebraic;
using nilnul.num.real.matrix.co_;
using nilnul.num.real.expr_.algebraic;
using System.Runtime.CompilerServices;



namespace nilnul.num.real.expr_.polynom.matrix_.sq_.isorow.hunch
{
	static public class _DeterminantX
	{


		static public P _ToDeterminant_0row_1ridge(
			 real.expr_.Algebraic[] row, real.expr_.Algebraic[] ridge
		)
		{
#if DEBUG


			var m = isorow._HunchX._ToHunchedIsorow_0row_1ridge(row, ridge);


			var w = m.GetLength(0);

			/// each row minus the row0
			for (var i = 1; i<w; i++)
			{
				for (int j = 0; j < w; j++)
				{
					m[i, j] -= m[0, j];
				}
			}

			///
			/// [
			///		a1 + l,		a2,a3, a4, ..., a[n]
			///		-l,			l1, 0	,0,		0
			///		-l,	0,			l2
			///		...
			///		-l,	0,	0					l[n]
			/// ]
			/// 
			nilnul.num.real.expr_.polynom.matrix_.sq.be_.paw._VowX._Vow_0sq(in m);

			/// <see cref="num.real.expr_.polynom.matrix_.sq_.paw_.nonnil8torso5diag._DeterminantX"/>
			/// <see cref="num.real.expr_.polynom.matrix_.sq_.paw._DeterminantX"/>
			/// 
			/// 
			/// 
#endif

			IEnumerable<int> diags = Enumerable.Range(0, m.GetLength(0));
			return bi_.mul.cumula.Cumulate.Singleton.cumulate(
					ridge
				)
				+/// the permutation each is negative, as two inside are swapped; but the l is also negated into the col0
				bi_.add.cumula.Cumulate.Singleton.cumulate(
					diags.Select(
						d => row[ d]
						*
						bi_.mul.cumula.Cumulate.Singleton.cumulate(
							diags.Where(x => x!=d).Select(
								k => ridge[k]
							)
						)
					)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static P _ToDeterminant_0row_1ridge(IEnumerable< P> row, IEnumerable< P> ridge)
		{
			return _ToDeterminant_0row_1ridge(
				row.ToArray(),ridge.ToArray()
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static P _ToDeterminant_0row_1ridge(IEnumerable< Var1> row, IEnumerable< Var1> ridge)
		{
			return _ToDeterminant_0row_1ridge(
				row.Select(v=> new P(v))
				,
				ridge.Select(r=>new P(r))
			);
		}

	}
}
