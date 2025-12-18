using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.tridiag
{
	static public class _DeterminantX
	{
		static public Q4 _Determinant_0tridiag(Q4[,] m) {
			var h= m.GetLength(0);
			if (h==0)
			{
				return (Q4)1;
			}
			if (h==1)
			{
				return m[0, 0];
			}

			var prev =(Q4) 1;
			var current = m[0, 0]; /// when h=0


			/// g = h-1
			for (int g = 1; g < h; g++)
			{
				var next = m[g, g ] * current - m[g , g - 1] * m[g - 1, g] * prev;
				prev = current;
				current = next;
			}

			return current;

		}
	}
}
