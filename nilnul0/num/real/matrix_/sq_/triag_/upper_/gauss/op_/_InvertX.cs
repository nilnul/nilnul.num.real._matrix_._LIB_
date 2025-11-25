using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.triag_.upper_.gauss.op_
{
	static public class _InvertX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="row">
		/// all other rows are basis; in this row, we can have some unnil cels off diagonal to the right (as we are in <see cref="triag_.IUpper"/>; <see cref="triag_.lower_.gauss.op_._InvertX"/> for offdiagonals to the left)
		/// </param>
		static public void _Invert_1row(
			ref Q[,] matrix
			,
			int row
		)
		{
			int w = matrix.GetLength(1);

			for (int c = row+1; c < w; c++)
			{
				matrix[row,c] = -matrix[row,c];
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
