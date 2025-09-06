using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.bi_
{
	/// <summary>
	/// blockwise, and other areas are filled with nils.
	/// Note the result might be nonsquare
	/// eg:
	///		[1,2]
	///			{3}
	///			
	///
	///	  would be:
	///			1,2,0
	///			0,0,3
	/// </summary>
	static public class _OffsetX
	{
		static public Q[,] Offset(Q[,] a, Q[,] b) {
			int aRows = a.GetLength(0);

			int bRows = b.GetLength(0);

			int aCols = a.GetLength(1);
			int bCols = b.GetLength(1);

			var r = new Q[
				aRows +bRows
				,
				aCols + bCols
			];

			int i = 0;
			for (; i < aRows; i++)
			{
				int j = 0;
				for (; j < aCols; j++)
				{
					r[i, j] = a[i, j];
				}

				for (int j1 = 0; j1 < bCols; j1++, j++)
				{
					r[i, j] = 0;
				}
			}

			for (int i1=0; i1 < bRows; i1++,i++)
			{
				int j = 0;
				for (; j < aCols; j++)
				{
					r[i, j] = 0;
				}

				for (int j1 = 0; j1 < bCols; j1++, j++)
				{
					r[i, j] = b[i1,j1];
				}
			}

			return r;

		}
	}
}
