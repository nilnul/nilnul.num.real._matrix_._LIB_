using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.col
{
	
	static public class _PivotX
	{




		/// <summary>
		/// called pivot.
		/// get the index of the first row that is not zero.
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="col"></param>
		/// <returns>
		/// -1 if pivot not found
		/// </returns>
		/// alias:
		///		firstUnnil
		static public long Pivot(ref Q[,] matrix, long col)
		{
			long high = matrix.GetLongLength(0);

			for (long h = 0; h < high; h++)
			{
				if (matrix[h,col] != 0)
				{
					return h;

				}

			}
			return -1;


		}
		static public int Pivot(ref Q[,] matrix, int col)
		{
			var high = matrix.GetLongLength(0);

			for (var h = 0; h < high; h++)
			{
				if (matrix[h,col] != 0)
				{
					return h;

				}

			}
			return -1;


		}

		
		static public int Pivot(ref double[,] matrix, int col)
		{
			var high = matrix.GetLongLength(0);

			for (var h = 0; h < high; h++)
			{
				if (matrix[h,col] != 0)
				{
					return h;

				}

			}
			return -1;


		}





	}
}
