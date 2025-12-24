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



namespace nilnul.num.real.matrix_.sq_.antim_.uniup
{
	static public class _CrestX
	{

		///define the matrix
		static public Q4[,] _Generate_1uniup(
			int wide, Q4 a, Q4 x
		)
		{
			var m = new Q4[wide, wide];
			for (int i = 0; i < wide; i++)
			{
				for (int j = i+1; j < wide; j++)
				{
					m[i, j] =a;
				}
			}
			num.real.matrix_.sq_.antim.of_._UpperX.OfStrictUpper(ref m);
			num.real.matrix_.sq.op_._CrestX.Crest(
				ref m, x
			);

			///<see cref="num.real.matrix_.sq_.negsym_.oddwide.be_.IDegenerate"/>, but the matrix here is not skew-symmetric. it is shifted skew symmetric.
			///
			/// 
			///
			return m;
		}
	}
}