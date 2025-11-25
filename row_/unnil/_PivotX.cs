using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.row_.unnil
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
			//Enumerable.Range(0,row)
			var w = matrix.GetLongLength(1);
			for (var i = 0l; i < w; i++)
			{
				if (matrix[row, i] != 0)
				{
					return i;

				}

			}
			return -1;


		}

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
		static public int _Pivot_1wide_2row(in Q[,] matrix, int width, int row)
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
