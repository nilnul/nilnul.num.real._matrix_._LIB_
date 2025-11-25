using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.rowspan_._slope_
{
	static public class _BySlantX
	{


		/// <summary>
		/// subtract from one row by another row; the two rows are different;
		/// </summary>
		/// <param name="m"></param>
		/// <param name="a"></param>
		/// <param name="b"></param>
		static public void _Slope_12row(
			in int[,] m
			,
			in int a
			,
			in int b
			,
			in int scale
		) {

			if (scale == -1)
			{
				 subtract_._BySlantX._Subtract_12row(in m, in a, in b);
				return;
			}

			rowspan_._SlantExceptSubtract._Slant_12row_3notNegOne(in m, in a, in b, scale);

		}



	}
}
