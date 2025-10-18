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
		static public Q[,] _Product_0productable(
			IEnumerable<Q[,]> matrixes
		) {
			return matrixes.Aggregate(
				(x,y) => real.matrix.bi_._MultiX._Multiply_1sociable(x,y)	
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Product_0productable(
			IEnumerable<double[,]> matrixes
		) {
			return matrixes.Aggregate(
				(x,y) => real.matrix.bi_._MultiX._Multiply_1sociable(x,y)	
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Product_1productable(
			 Q[,] matrix,

			IEnumerable< Q[,]> matrixes
		) {
			return matrixes.Aggregate(
				matrix,
				(a,c) => real.matrix.bi_._MultiX._Multiply_1sociable(a,c)	
			);

			//return _Product_0productable((IEnumerable<Q[,]>)	matrixes.Prepend(matrix) ) ;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Product_1productable(
			 Q[,] matrix,

			params Q[][,] matrixes
		) {

			return _Product_1productable(matrix, (IEnumerable<Q[,]>)	matrixes ) ;
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
