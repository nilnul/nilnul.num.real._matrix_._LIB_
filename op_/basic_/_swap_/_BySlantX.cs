using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.rowspan_._swap_
{
	static public class _BySlantX
	{

		static public void _Swap_12row(
			in int[,] m
			,
			in int a
			,
			in int b
		) {
			///first we sum the two
			///
			_SlantExceptSubtract._Slant_12row_3notNegOne(in m, in a, in b, 1);
			//: now the first row is the sum.
			/// /: a+b, b

			///we change the second row
			///
			/// the second row is the old first row's neg
			subtract_._BySlantX._Subtract_12row(in m, in b, in a);
			/// /: a+b, b -(a+b) = -a

			/// now the second row is the old first row

			_scale_._BySlantX._Scale_1row_2unnil(in m, in a, -1);
			//: a+b, a

			subtract_._BySlantX._Subtract_12row(in m, in a, in b);
			/// a+b-a=b,a


		}



	}
}
