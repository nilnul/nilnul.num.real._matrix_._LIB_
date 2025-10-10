using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.matrix.duo_.associable;

namespace nilnul.num.real.matrix.str_.started_.productable
{
	static public class _ProductX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Product_0productable(
			IEnumerable<double[,]> matrixes
		) {
			return matrixes.Aggregate(
				(x,y) => real.matrix.bi_._MultiX._Multiply_1sociable(x,y)	
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Product_0productable(
			params double[][,] matrixes
		) {

			return _Product_0productable((IEnumerable<double[,]>)	matrixes ) ;

			return matrixes.Aggregate(
				(x,y) => real.matrix.bi_._MultiX._Multiply_1sociable(x,y)	
			);


		}


	}
}
