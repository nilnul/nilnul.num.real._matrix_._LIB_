using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.std_.indep_
{
	/// <summary>
	/// <see cref="nilnul.num.real.matrix_.ILandscape"/>
	/// </summary>
	static public  class _LandscapeX
	{
		static public Q[,] OfRowsCols(
			int rows
			,
			int cols
		)
		{
			var r = new Q[rows, cols];

			for (var i = 0; i < rows; i++)
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

			return r;
		}
	}
}
