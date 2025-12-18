using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.tridiag_.toeplitz._determ_.by_
{
	static public class _ByRecurX
	{
		static public Q4 _Determinant_ofTridiagToeplitz(int wide, Q4 c00, Q4 c01, Q4 c10) {
			if (wide==0)
			{
				return (Q4)1;
			}
			if (wide==1)
			{
				return c00;
			}

			var prev =(Q4) 1;
			var current = c00; /// when h=0

			/// g = h-1
			for (int g = 1; g < wide; g++)
			{
				var next = c00* current - c01  * c10  * prev;
				prev = current;
				current = next;
			}

			return current;

		}
	}
}
