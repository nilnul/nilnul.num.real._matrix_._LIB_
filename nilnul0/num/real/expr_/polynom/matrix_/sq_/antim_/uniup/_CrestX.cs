using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.num.real.expr_._algebraic;
using nilnul.obj.stream_.slider.to_;
using nilnul.num.real.expr_.polynom.matrix_.sq;
using nilnul.obj.str;
using nilnul.num.real.expr_;
using P = nilnul.num.real.expr_.Algebraic;
using System.Diagnostics.Contracts;

namespace nilnul.num.real.expr_.polynom.matrix_.sq_.antim_.uniup
{
	/// <see cref="nilnul.num.real.exp"/>
	/// <summary>
	/// </summary>
	static public class _CrestX
	{

		/// <summary>
		/// define the matrix.
		/// </summary>
		/// <param name="wide"></param>
		/// <param name="a"></param>
		/// <param name="x"></param>
		/// <returns>
		/// eg:
		///		[
		///			x, a, a, a
		///			-a,x,a,a
		///			......
		///			-a,-a,-a, x
		///		]
		/// </returns>
		static public real.expr_.Algebraic[,] Generate(
			int wide, num.real.expr_.Var1 a, num.real.expr_.Var1 x
		)
		{

			var m = new P[wide, wide];
			for (int i = 0; i < wide; i++)
			{
				for (int j = i+1; j < wide; j++)
				{
					m[i, j] =a;
				}
			}

			num.real.expr_.polynom.matrix_.sq_.antim.of_._UpperX.OfStrictUpper(ref m);
			num.real.expr_.polynom.matrix_.sq_.isosize.bi_._add_.at_._RidgeUpX._RidgeUp_0shift(
				ref m, x
			);

			///<see cref="num.real.matrix_.sq_.negsym_.oddwide.be_.IDegenerate"/>, but the matrix here is not skew-symmetric. it is shifted skew symmetric.
			///
			/// 
			///
			return m;

			///return num.real.expr_.polynom.matrix_.sq._DeterminantX._Determinant_0sq(m);
		}
	}
}