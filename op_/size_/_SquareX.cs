using System;

namespace nilnul.num.real.matrix.op_.size_
{
	static public class _SquareX
	{
		static public Q4[,] _ToSquare_0diags(int rows, Q4[,] matrix)
		{
			var h = matrix.GetLength(0);
			var w = matrix.GetLength(1);

			var o = new Q4[rows, rows];
			for (var i = 0; i < rows; i++)
			{
				for (var j = 0; j < rows; j++)
				{
					o[i, j] =  (i<h && j<w) ? matrix[i, j] : 0;
				}
			}
			return o;

		}

		static public Q4[,] ToSquare( Q4[,] matrix)
		{
			var h = matrix.GetLength(0);
			var w = matrix.GetLength(1);

			var max = Math.Max(h, w);

			var o = new Q4[max, max];
			for (var i = 0; i < max; i++)
			{
				for (var j = 0; j < max; j++)
				{
					o[i, j] =  (i<h && j<w) ? matrix[i, j] : 0;
				}
			}
			return o;

		}

	}
}
