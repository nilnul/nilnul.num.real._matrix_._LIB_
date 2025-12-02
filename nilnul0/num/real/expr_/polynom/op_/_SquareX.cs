using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.polynom.op_
{
	static public class _SquareX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public P Square(this P p) {
			return p*p;
		}
	}
}
