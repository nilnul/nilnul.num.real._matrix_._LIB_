using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix_.sq_.invertible.op_
{
	static public class _InvertX
	{


		/// <summary>
		/// A\ = A*  / |A|
		/// </summary>
		/// <param name="nonsinglularSqMatrix">
		/// 'ref' means this would be mutated. use this method when you don't mind it being mutated.
		/// </param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  Q4[,] _Invert_0invertible(ref Q4[,] nonsinglularSqMatrix) {

			return _invert_.by_._ByRatioX._Invert_0invertible(ref nonsinglularSqMatrix);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  Q4[,] _Invert_0invertible(this Q4[,] nonsinglularSqMatrix) {

			return _invert_.by_._ByRatioX._Invert_0invertible(nonsinglularSqMatrix);

		}

		
	}
}
