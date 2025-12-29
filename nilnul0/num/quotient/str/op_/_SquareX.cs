using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.str.op_
{
	static public class _SquareX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<Q4> Square(in IEnumerable<Q4> x) {
			return x.Select(a=>a*a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<Q4> Square(this IEnumerable<Q4> x) {
			return Square(in x);
		}

	}
}
