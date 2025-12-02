using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.invertible.op_
{
	static public class _InvertX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  double[,] _Invert_0invertible(this double[,] nonsinglularSqMatrix) {

			//return _invert_.by_._ByGaussianX._Invert_0invertible(nonsinglularSqMatrix);
			
			return num.real.matrix.op_.unary_._ScaleX.Divide2new(
				//Adjugate.Matrix(nonsinglularSqMatrix)
				matrix_.sq.op_._AdjugateX._Adjugate_0equilat(nonsinglularSqMatrix)
				,

				//sq.to_.scalar_._DeterminantX._Determinant_assumeSquare(nonsinglularSqMatrix)
				sq._DeterminantX._Determinant_0sq(nonsinglularSqMatrix)

			);
		}


		/// <summary>
		/// A\ = A*  / |A|
		/// </summary>
		/// <param name="nonsinglularSqMatrix"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  Q[,] _Invert_0invertible(this Q[,] nonsinglularSqMatrix) {

			return num.quotient.matrix_.sq_.invertible.op_._InvertX._Invert_0invertible(nonsinglularSqMatrix);
			//return _invert_.by_._ByGaussianX._Invert_0invertible(nonsinglularSqMatrix);

	
		}

		
	}
}
