using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.std_
{
	/// <summary>
	/// <see cref="nilnul.num.real.matrix_.ILandscape"/>
	/// </summary>
	static public class _LandscapeX
	{
		static public Q[,] _OfRowsCols_2rank(
			int rows
			,
			int cols
			, int rank
		)
		{
			var r = new Q[rows, cols];
			var i = 0;
			for (; i < rank; i++)
			{
				var j = 0;
				while (j<i)
				{
					r[i, j++] =0;

				}

				/// here j might be greater than cols. but as this is landscape, 
				r[i, j++] = 1;

				while (j<cols)
				{

					r[i, j++] = 0;
				}


			}

			for (; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] =0;
				}
			}


			return r;
		}
	}
}
