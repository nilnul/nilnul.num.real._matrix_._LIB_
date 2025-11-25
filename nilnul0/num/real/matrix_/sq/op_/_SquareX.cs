using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nilnul.num.real.matrix_.sq.op_
{
	static public class _SquareX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static R[,] _Square_0equilat(this R[,] x) {
			return nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(x, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Q[,] _Square_0equilat(this Q[,] x) {
			return nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(x, x);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int[,] _Square_0equilat(this int[,] x) {
			return nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(x, x);
		}



	}


}
