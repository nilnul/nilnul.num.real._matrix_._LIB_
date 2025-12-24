using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.num.real.expr_._algebraic;
using nilnul.obj.stream_.slider.to_;
using nilnul.num.real.expr_.polynom.matrix_.sq;
using nilnul.obj.str;
using nilnul.num.real.expr_;
using P = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.matrix_.sq_.isorow
{
	/// <summary>
	/// <see cref="real.matrix_.sq_.unival._CrestX"/>
	/// </summary>
	static public class _CrestX
	{
		static public Q4[,] Generate(
			 Q4[] row, Q4 crest
		)
		{
			var n = row.Length;

			var m = new Q4[n, n];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j<n; j++)
				{
					m[i, j] = row[j];
				}
			}
			return m;
		}
	}
}