using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.triag_.upper_.gauss.op_
{
	static public class _InvertX
	{
		static public void _Invert_1unnilRow(
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
	}
}
