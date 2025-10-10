using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.rowspan_
{
	/// <summary>
	/// 
	/// </summary>
    static public class _SlantExceptSubtract
    {
		static public void _Slant_12row_3notNegOne(
			in int[,] m
			,
			in int r
			,
			in int row2swallow
			,
			in int multiplier
		)
		{

			int cols = m.GetLength(1);

			for (int col = 0; col < cols; col++)
			{
				m[r, col] += multiplier * m[row2swallow, col];
			}
		}
	}


}
