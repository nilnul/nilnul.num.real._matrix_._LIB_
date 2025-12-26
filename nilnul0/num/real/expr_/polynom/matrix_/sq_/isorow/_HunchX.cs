using nilnul.num.real.expr_;
using nilnul.num.real.expr_._algebraic;
using nilnul.num.real.expr_.polynom.matrix_.sq;
using nilnul.num.real.matrix.co_;
using nilnul.obj.str;
using nilnul.obj.stream_.slider.to_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using P = nilnul.num.real.expr_.Algebraic;



namespace nilnul.num.real.expr_.polynom.matrix_.sq_.isorow
{
	/// <see cref="num.real.matrix.diag.op_.IRidge"/>
	/// <summary>
	/// 
	/// </summary>
	static public class _HunchX
	{
		static public P[,] _ToHunchedIsorow_0row_1ridge(
				 real.expr_.Algebraic[] row, real.expr_.Algebraic[] ridge
			)
		{
			var wide = row.Length;

			var m = new nilnul.num.real.expr_.Algebraic[
				wide
				,
				wide
			];

			for (var i = 0; i<wide; i++)
			{
				int j = 0;
				for (; j < i; j++)
				{
					m[i, j] = row[j];
				}

				m[i, i] = row[i] + ridge[i];

				j++;
				for (; j < wide; j++)
				{
					m[i, j] = row[j];
				}

			}

			/// <see cref="num.real.expr_.rithmetic."/>
			return m;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static P[,] _ToHunchedIsorow_0row_1ridge(IEnumerable<P> row, IEnumerable<P> ridge)
		{
			return _ToHunchedIsorow_0row_1ridge(
				row.ToArray(), ridge.ToArray()
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static P[,] _ToHunchedIsorow_0row_1ridge(IEnumerable<Var1> row, IEnumerable<Var1> ridge)
		{
			return _ToHunchedIsorow_0row_1ridge(
				row.Select(v => new P(v))
				,
				ridge.Select(r => new P(r))
			);
		}

	}
}