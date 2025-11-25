using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.of_.row_
{
	/// <summary>
	/// padding zeros across the row;
	/// </summary>
	static public class _PaddingX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="paddingUpper">
		/// how many rows above the given row;
		/// </param>
		/// <param name="row"></param>
		/// <param name="paddingLower">
		/// how many rows below the given row
		/// </param>
		/// <returns></returns>
		static public double[,] _Padding_0upper_2lower(
			int paddingUpper,
			double[] row
			,
			int paddingLower
		)
		{
			int w = row.Length;
			var o = new double[paddingUpper+1+ paddingLower, w];

			for (int i = 0; i < w; i++)
			{
				o[paddingUpper, i] = row[i];
			}

			return o;
		}
		static public Q[,] _Padding_0upper_2lower(
			int paddingUpper,
			Q[] row
			,
			int paddingLower
		)
		{
			int w = row.Length;
			int h = paddingUpper+1+ paddingLower;
			var o = new Q[h, w];

			int c = 0;

			for (; c < w; c++)
			{
				int r = 0;

				for (; r < paddingUpper; r++)
				{
					o[r, c] = 0;

				}
				o[r++, c] = row[c];

				for (; r < h; r++)
				{
					o[r, c] = 0;
				}
			}

			return o;
		}



		static public double[,] _Padding_0upper_2lower(
			int paddingUpper,
			IEnumerable<double> row
			,
			int paddingLower
		)
		{
			var o = new double[
				paddingUpper+1+ paddingLower, row.Count()
			];

			var c = 0;
			foreach (var v in row)
			{
				o[paddingUpper, c++] = v;
			}

			return o;
		}



	}
}
