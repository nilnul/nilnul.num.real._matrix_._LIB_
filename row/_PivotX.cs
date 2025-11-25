using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.row
{
	
	static public class _PivotX
	{




		/// <summary>
		/// called pivot.
		/// get the index of the first col that is not zero.
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="row"></param>
		/// <returns>
		/// -1 if pivot not found
		/// </returns>
		/// alias:
		///		firstUnnil
		static public long Pivot(in Q[,] matrix, long row)
		{
			long w = matrix.GetLongLength(1);
			for (long i = 0; i < w; i++)
			{
				if (matrix[row, i] != 0)
				{
					return i;

				}

			}
			return -1;


		}

		/// <summary>
		/// -1 if no unnil cel is found;
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="row"></param>
		/// <returns></returns>
		static public int Pivot(in Q[,] matrix, int row)
		{
			int w = matrix.GetLength(1);

			for (var i = 0; i < w; i++)
			{
				if (matrix[row, i] != 0)
				{
					return i;

				}

			}
			return -1;

		}
		static public int _Pivot_1wide_2row(in Q[,] matrix,in int width,in int row)
		{
			for (var i = 0; i < width; i++)
			{
				if (matrix[row, i] != 0)
				{
					return i;
				}
			}
			return -1;

		}


		static public int Pivot(in double[,] matrix, int row)
		{
			int w = matrix.GetLength(1);

			for (var i = 0; i < w; i++)
			{
				if (matrix[row, i] != 0)
				{
					return i;

				}

			}
			return -1;


		}




	}
}
