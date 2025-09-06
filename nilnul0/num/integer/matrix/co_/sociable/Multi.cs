using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.matrix.co_.sociable
{
	static public class _MultiX
	{

		static public int _InnerProduct_0social_1front_2row_3behind_4col(int socialSize,int[,] a, int row, int[,] b, int col) {
			var r = 0;
			for (int i = 0; i < socialSize; i++)
			{
				r += a[row, i] * b[i, col];
			}
			return r;
		}
		static public int[,] _Multi_0sq_1isosize(this int[,] a, int[,] b) {

			var rows = a.GetLength(0);
			int cols = b.GetLength(1);

			var socialSize = a.GetLength(1);

			int[,] c = new int[rows, cols];//every element has been initialized to 0.

			for (int i1 = 0; i1 < rows; i1++)
			{
				for (int j = 0; j < cols; j++)
				{
					c[i1, j] = _InnerProduct_0social_1front_2row_3behind_4col(
						socialSize
						,
						a
						,
						i1
						,
						b
						,
						j
					);

				}

			}
			return c;
		}

	}
}
