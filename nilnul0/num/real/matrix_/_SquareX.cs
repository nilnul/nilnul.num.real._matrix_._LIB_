using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nilnul.num.real.matrix_
{
	static public  class _SquareX
	{


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] Init8dbl(int dimension) {

			return nilnul.obj.matrix_._SquareX._Init_0width<double>(dimension);

		}

		[Obsolete(nameof(real.matrix_.sq_._NilX.Generate8quotient))]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Init8quotient(int dimension) {

			return num.real.matrix_.sq_._NilX.Generate8quotient(dimension);

			//return nilnul.num.real.matrix_._NaughtX.Generate8quotient(dimension,dimension);

			//return nilnul.obj.matrix_._SquareX._Init_0width<Q>(dimension);

		}


		
	}
}
