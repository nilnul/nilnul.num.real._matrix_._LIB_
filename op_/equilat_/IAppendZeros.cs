using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.equilat_
{
	/// <see cref="nilnul.obj.matrix_.iso"/>
	/// <see cref="nilnul.num.real.matrix_.isowide"/>
	/// 
	/// <summary>
	/// append(<see cref="obj.matrix.str"/>) <see cref="real.matrix_.INilful"/>
	/// </summary>
	/// 
	static public class _AppendNaughtX
	{
		static public Q[,] _AppendNaught_0portrait_1rows_2cols(Q[,] matrix, int rows, int cols)
		{
			var r = new Q[rows, rows];

			for (var i = 0; i < rows; i++)
			{
				var j = 0;
				for (; j < cols; j++)
				{
					r[i, j] = matrix[i, j];
				}

				for (; j < rows; j++)
				{
					r[i, j] = 0;
				}


			}
			return r;
		}

		static public Q[,] _AppendNaught_0landscape_1rows_2cols(Q[,] matrix, int rows, int cols)
		{
			var o = new Q[cols, cols];

			for (var c = 0; c < cols; c++)
			{
				var r = 0;
				for (; r < rows; r++)
				{
					o[r, c] = matrix[r, c];
				}

				for (; r < cols; r++)
				{
					o[r, c] = 0;
				}


			}
			return o;
		}



		static public Q[,] AppendNaught(Q[,] matrix)
		{
			var rows = matrix.GetLength(0);
			var cols = matrix.GetLength(1);
			return rows >= cols
				? _AppendNaught_0portrait_1rows_2cols(matrix, rows, cols)
				: _AppendNaught_0landscape_1rows_2cols(matrix, rows, cols);
		}
	}

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		augment naught
	internal class IAppendZeros
	{

	}
}
