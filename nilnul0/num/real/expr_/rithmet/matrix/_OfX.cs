using nilnul.num.real.expr_.algebraic;
using nilnul.txt_.names.fro_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.rithmet.matrix
{

	/// <summary>
	/// </summary>
	static public class _OfX
	{

		public static Frac[,] ToFracs(in A[,] m)
		{
			int height = m.GetLength(0);
			var o = new Frac[height,height];
			for (int r = 0; r<height; r++) {
				for (int c = 0; c < height; c++)
				{
					o[r, c] = m[r, c];
				}
			}

			return (
				o
			);
		}
	}
}
