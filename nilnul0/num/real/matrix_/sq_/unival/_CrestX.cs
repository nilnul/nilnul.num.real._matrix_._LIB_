using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.num.real.expr_._algebraic;
using nilnul.obj.stream_.slider.to_;
using nilnul.num.real.expr_.polynom.matrix_.sq;
using nilnul.obj.str;
using nilnul.num.real.expr_;
using P = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.matrix_.sq_.unival
{
	static public class _CrestX
	{
		static public Q4[,] Generate(int wide
			, Q4 unival, Q4 crest
		)
		{
			var m = nilnul.num.real.matrix_.sq_._UnivalX.Generate(wide, unival);

			for (int i = 0; i < wide; i++)
			{
				m[i, i] +=crest;

			}
			return m;
		}
	}
}