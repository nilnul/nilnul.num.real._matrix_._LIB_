using nilnul.num.real.matrix.co_.multible;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq.op_
{
	/// <summary>
	/// given invertible square matrix P,
	/// , then for input square matrix Q
	/// , we get P^T Q P
	/// </summary>
	static public class _CongruentX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="invertible"></param>
		/// <param name="x"></param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Congruent_0invertible_1sociable(double[,] invertible, double[,] x) {

			return _Congruent_0invertible_1transposed_2sociable(
				invertible
				,
				matrix.op_.Transpose.Op(invertible)
				,
				x
			);

		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Congruent_0invertible_1transposed_2sociable(
			double[,] invertible
			,
			double [,] transposed
			,
			double[,] x
		) {

			return transposed._Multiply_assumeSociable(x)._Multiply_assumeSociable(invertible);
		}


	}
}
