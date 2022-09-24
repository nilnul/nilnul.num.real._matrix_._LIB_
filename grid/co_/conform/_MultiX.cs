using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.grid.co_.conform
{
	static public class _MultiX
	{
		static public double[,][,] _Multi_assumeConform(
			double[,][,] x
			,
			double[,][,] y

		) {

			var r = new double[x.GetLength(0) , y.GetLength(1) ][,];

			for (int i = 0; i < x.GetLength(0); i++)
			{
				for (int j = 0; j < y.GetLength(1); j++)
				{
					r[i, j] = matrix.vec.co_.conform. _SopX._Sop_assumeConform(
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
