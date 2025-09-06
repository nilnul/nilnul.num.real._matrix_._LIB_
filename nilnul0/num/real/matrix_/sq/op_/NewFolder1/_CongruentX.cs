using nilnul.num.real.matrix.co_.multible;

namespace nilnul.num.real.matrix_.sq.op_
{
	/// <summary>
	/// given invertible square matrix P,
	/// , then for input square matrix Q
	/// , we get P^T Q P
	/// </summary>
	static public class _CongruentX
	{
		static public double[,] _Congruent_0invertible_1sociable(double[,] invertible, double[,] x) {

			return _Congruent_0invertible_1transposed_2sociable(
				invertible
				,
				matrix.op_.unary_.Transpose.Op(invertible)
				,
				x
			);

		}
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
