using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.diag
{
	/// <summary>
	/// <see cref="real.matrix_.sq._RidgeX"/>
	/// </summary>
	static public class _RidgeX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<Q> _Ridge_0equilat(Q[,] m) {
			return nilnul.obj.matrix_.sq._DiagonalX._Diagonal_0sq(m);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Ridge_0equilat(double[,] m) {
			return nilnul.obj.matrix_.sq._DiagonalX._Diagonal_0sq(m);
		}


	}
}
