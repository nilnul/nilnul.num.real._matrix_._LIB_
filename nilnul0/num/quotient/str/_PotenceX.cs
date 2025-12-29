using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.str
{
	static public class _PotenceX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 Potence(in IEnumerable<Q4> x) {
			return num.quotient.str._SumX.Sum( num.quotient.str.op_._SquareX.Square(in x)
			);
		}
	}
}
