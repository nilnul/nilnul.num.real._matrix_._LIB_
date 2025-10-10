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
		static public long Pivot(ref Q[,] matrix, long row)
		{
			for (long i = 0; i < matrix.GetLongLength(1); i++)
			{
				if (matrix[row, i] != 0)
				{
					return i;

				}

			}
			return -1;


		}

		static public int Pivot(ref Q[,] matrix, int row)
		{
			for (var i = 0; i < matrix.GetLength(1); i++)
			{
				if (matrix[row, i] != 0)
				{
					return i;

				}

			}
			return -1;


		}

		static public int Pivot(ref double[,] matrix, int row)
		{
			for (var i = 0; i < matrix.GetLength(1); i++)
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
