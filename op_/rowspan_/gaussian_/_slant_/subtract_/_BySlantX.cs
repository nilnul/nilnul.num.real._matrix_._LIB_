using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.rowspan_.subtract_
{
	static public class _BySlantX
	{


		/// <summary>
		/// subtract from one row by another row; the two rows are different;
		/// </summary>
		/// <param name="m"></param>
		/// <param name="a"></param>
		/// <param name="b"></param>
		static public void _Subtract_12row(
			in int[,] m
			,
			in int a
			,
			in int b
		) {
			/// 
			_scale_._BySlantX._Scale_1row_2unnil(in m,in b,  -1);
			//: a, -b

			_SlantExceptSubtract._Slant_12row_3notNegOne(in m, in a, in b, 1);
			//: a-b, -b

			_scale_._BySlantX._Scale_1row_2unnil(in m,in b,  -1);
			//: a, b

		}



	}
}
