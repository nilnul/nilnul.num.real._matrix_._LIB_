using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix_.sq.op_
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
		static public  Q4[,] _Invert_0square(ref Q4[,] nonsinglularSqMatrix) {

			return _invert_.by_._ByRatioX._Invert_0square(ref nonsinglularSqMatrix);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  Q4[,] _Invert_0square(this Q4[,] nonsinglularSqMatrix) {

			return _invert_.by_._ByRatioX._Invert_0square(nonsinglularSqMatrix);

		}

		
	}
}
