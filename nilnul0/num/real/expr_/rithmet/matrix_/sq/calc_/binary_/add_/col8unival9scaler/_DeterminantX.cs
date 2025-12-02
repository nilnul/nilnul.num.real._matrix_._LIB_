using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.num.real.expr_._algebraic;
using nilnul.obj.expr.var;
using System.Linq.Expressions;
using nilnul.obj.stream_.slider.to_;
using nilnul.txt.be_;
using System.Diagnostics.Contracts;
using nilnul.num.real.expr_;
using System.Diagnostics;


namespace nilnul.num.real.expr_.rithmet.matrix_.sq.calc_.binary_.add_.col8unival9scaler
{
	static public class _DeterminantX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">
		/// [
		///		a,	b,	c
		///		a,	b,	c
		///		a,	b,	c
		/// ]
		/// </param>
		/// <param name="l">
		///		[
		///			d
		///				,d
		///					,d
		///		]
		/// </param>
		/// <returns>
		/// the matrix, of which the determinant is computed, is the sum of <paramref name="m"/> and <see cref="l"/>
		/// :
		/// [
		///		a+l,	b,		c
		///		a,		b+l,	c
		///		a,		b,		c+l
		/// ]
		/// 
		/// </returns>

		static public algebraic.Frac _Determinant_0col8unival_1scaler(real.expr_.algebraic.Frac[,] m, real.expr_.algebraic.Frac l)
		{

			var height = m.GetLength(0);

			#region inference
#if true4

			/// add all cols to the first col:
			/// 
			for (int j = 1; j < height; j++)
			{

				for (int i = 0; i<height; i++)
				{
					m[i, 0] +=m[i, j];

				}
			}
			/// the cel in col[0]: sum(a[i]) -l
			/// 

			/// each nonfirst row minus the first row:
			/// 
			for (int i = 1; i<height; i++)
			{
				for (int j = 0; j < height; j++)
				{
					m[i, j] -=m[0, j];

				}
			}

			/// the result is upper triag
			/// 
			Debug.Assert(
				nilnul.num.real.expr_.rithmet.matrix_.sq.be_.triag_._UpperX._IsUpper_0sq(m)
			);


#endif
			#endregion

			///the inferred ans, 
			return (
				Enumerable.Range(0, height).Select(
					i => m[0, i]
				)
				.Aggregate(
					real.expr_.algebraic.Frac.Nil, (a, c) => a+c
				)
				+ l
			)
			*
			num.real.expr_.rithmet.op_._PonentX._Pon_0num(

					l
					,

					height-1
			);

		}
	}
}
