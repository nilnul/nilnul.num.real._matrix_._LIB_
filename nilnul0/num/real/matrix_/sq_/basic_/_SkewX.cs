using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.basic_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	static public class _SkewX
	{
		/// <summary>
		/// the effect of this as a left multiplier is:
		/// 
		/// row[<paramref name="i"/>] += <paramref name="scale"/> * row[ <paramref name="j"/> ]
		/// 
		/// </summary>
		/// <remarks>
		/// 
		/// 
		/// </remarks>
		/// <param name="size"></param>
		/// <param name="i"></param>
		/// <param name="scale">can be nil.
		/// if pivot of row[ <paramref name="i"/>] is 1, then <paramref name="scale"/> is set as the negation of the pivot of row[<paramref name="j"/>]
		/// 
		/// </param>
		/// <returns></returns>
		static public double[,] _Generate_0plural_1row_2other(int size, int i, int j, double scale)
		{
			var o = new double[size, size];
			for (int r = 0; r < size; r++)
			{
				o[r, r] =1;
			} /// canonical
			o[i, j] = scale;
			return o;
		}

		static public Q[,] _Generate_0plural_1row_2other(int size, int i, int j, Q scale)
		{
			var o = new Q[size, size];
			for (int r = 0; r < size; r++)
			{
				o[r, r] =1;
			} /// canonical
			o[i, j] = scale;
			return o;
		}


	}
}
