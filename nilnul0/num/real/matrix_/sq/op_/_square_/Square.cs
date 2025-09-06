using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nilnul.num.real.matrix.doubleElement.squareMatrix.op
{
	[Obsolete(nameof(num.real.matrix_.sq.op_._SquareX))]
	public  class Square
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double[,] Eval(double[,] x) {
			return nilnul.num.real.matrix.MatrixX131113.Multiply(x, x);
		}
	}


}
