using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.basic_.skews_.slant.op_
{
	static public class _InvertX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="row">
		/// all other rows are basis; in this row, we can have some unnil cels off diagonal 
		/// </param>
		static public void _Invert_1row(
			ref Q[,] matrix
			,
			int row
		)
		{
			int w = matrix.GetLength(1);
			int c = 0;
			for (; c < row; c++)
			{
				matrix[row, c] = -matrix[row, c];
			}
			c++;
			for (; c < w; c++)
			{
				matrix[row, c] = -matrix[row, c];
			}

		}

		static public Q[,] _Invert_1row(
			 Q[,] matrix
			,
			int row
		)
		{

			var cloned = (Q[,])matrix.Clone();
			_Invert_1row(ref cloned, row);
			return cloned;
		}

	}
}
