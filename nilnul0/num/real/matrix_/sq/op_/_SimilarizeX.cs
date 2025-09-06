using nilnul.num.real.matrix.co_.multible;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq.op_
{
	/// <summary>
	/// given invertible square matrix P,
	/// , then for input square matrix Q
	/// , we get P \ Q P
	/// </summary>
	static public class _SimilarizeX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="invertible"></param>
		/// <param name="x"></param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Similarize_0invertible_1isosize(double[,] invertible, double[,] x) {

			return _Similarize_0invertible_1inverted_2isosize(
				invertible
				,
				matrix_.sq_.invertible.op_.Invert._Matrix_0invertible(invertible)
				,
				x
			);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Similarize_0invertible_1inverted_2isosize(
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
