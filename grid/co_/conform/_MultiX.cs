using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.grid.co_.conform
{
	/// <summary>
	/// blockwise multiplication
	/// </summary>
	static public class _MultiX
	{
		static public double[,][,] _Multi_01conform(
			double[,][,] x
			,
			double[,][,] y

		) {

			int rows = x.GetLength(0);
			int cols = y.GetLength(1);


			var r =
				//new double[ ,  ][rows,cols]
				new double[rows,cols][ ,  ]		///major first
			;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] = matrix.vec.co_.sommable. _SomX._Som_01sommable(
						 nilnul.obj.matrix._RowsX.Row(x, i)
						 ,
						 nilnul.obj.matrix._ExtensionsX.Col(y, j)
					);
				}

			}

			return r;
		}
		static public Q[,][,] _Multi_01conform(
			Q[,][,] x
			,
			Q[,][,] y

		) {

			int rows = x.GetLength(0);
			int cols = y.GetLength(1);


			var r =
				//new double[ ,  ][rows,cols]
				new Q[rows,cols][ ,  ]		///major first
			;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] = matrix.vec.co_.sommable. _SomX._Som_01sommable(
						 nilnul.obj.matrix._RowsX.Row(x, i)
						 ,
						 nilnul.obj.matrix._ExtensionsX.Col(y, j)
					);
				}

			}

			return r;
		}


	}
}
