using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.be_.aug_
{

	static public class _HomoX
	{
		static public bool _IsHomo_0aug_1wide(
			 Q[,]	matrix, in int wide
		) {
			/// it's aug.
			/// 
			var wMinus = wide-1;
			return Enumerable.Range(
				0, matrix.GetLength(0)
			).All(
				r=>matrix[r,wMinus] ==0	
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _IsHomo_0aug(
			 in Q[,]	matrix
		) {
			return _IsHomo_0aug_1wide(matrix, matrix.GetLength(1));
		}



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool IsHomo(
			in Q[,]	matrix
		) {
			var w = matrix.GetLength(1);
			return _AugmentedX._Be_0wide(in w) && _IsHomo_0aug_1wide(matrix, in w);
		}


	}

	public class Homo : real.matrix.Be8quotientI
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool be(in Q4[,] val)
		{
			return _HomoX.IsHomo(in val);
		}
	}
}
