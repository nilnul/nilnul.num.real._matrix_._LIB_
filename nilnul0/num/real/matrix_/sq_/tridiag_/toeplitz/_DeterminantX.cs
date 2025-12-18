using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.tridiag_.toeplitz
{
	static public class _DeterminantX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _Determinant_ofTridiagToeplitz(int wide, Q4 c00, Q4 c01, Q4 c10) {
			return _determ_.by_._ByRecurX._Determinant_ofTridiagToeplitz(
				wide, c00, c01, c10
			);

		}
	}
}
