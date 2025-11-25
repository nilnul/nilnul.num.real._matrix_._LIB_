using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.of_.col_
{
	/// <summary>
	/// padding zeros across the col;
	/// </summary>
	static public class _PaddingX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="paddingLeft">
		/// how many cols left to the given col;
		/// </param>
		/// <param name="col"></param>
		/// <param name="paddingRight">
		/// how many cols below the given col
		/// </param>
		/// <returns></returns>
		static public double[,] _Padding_0left_2right(
			int paddingLeft,
			double[] col
			,
			int paddingRight
		)
		{
			int h = col.Length;
			var o = new double[h, paddingLeft+1+ paddingRight ];

			for (int i = 0; i < h; i++)
			{
				o[i, paddingLeft] = col[i];
			}

			return o;
		}
		static public Q[,] _Padding_0left_2right(
			int paddingLeft
			,
			Q[] col
			,
			int paddingRight
		)
		{
			int h0 = col.Length;
			int w = paddingLeft+1+ paddingRight;
			var o = new Q[ h0,w];

			int r0 = 0;

			for (; r0 < h0; r0++)
			{
				int c = 0;

				for (; c < paddingLeft; c++)
				{
					o[ r0, c] = 0;

				}
				o[r0,c++ ] = col[r0];

				for (; c < w; c++)
				{
					o[r0, c] = 0;
				}
			}

			return o;
		}



		static public double[,] _Padding_0left_2right(
			int paddingLeft,
			IEnumerable<double> col
			,
			int paddingRight
		)
		{
			var o = new double[
				col.Count()
				, 
				paddingLeft+1+ paddingRight
			];

			var r = 0;
			foreach (var v in col)
			{
				o[r++,paddingLeft] = v;
			}

			return o;
		}



	}
}
