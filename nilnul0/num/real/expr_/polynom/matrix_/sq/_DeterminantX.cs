using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom.matrix_.sq
{
	static public class _DeterminantX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Algebraic _Determinant_0sq(
			this Algebraic[,] d
		)
		{
			return expr_.polynom.matrix_.sq._determ_.by_._ByPermuteX._Determ_0sq(d);
			//return expr_.polynom.matrix_.sq._determ_.by_._BySubmatrixX._Determinant_0sq(d);
		}
	}
}
