using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.triag_.lower_.gauss.op_
{
	static public class _InvertX
	{
		static public void _Invert_1row(
			ref Q[,] matrix
			,
			int row
		)
		{
			//int w = matrix.GetLength(1);

			for (int c = 0; c < row; c++)
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
