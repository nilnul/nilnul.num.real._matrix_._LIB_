using System.Numerics;

namespace nilnul.num.quotient.matrix.of_
{
	static public class _OfIntegersX
	{
		static public Q[,] OfIntegers(BigInteger[,] matrix) {
			var width = matrix.GetLength(0);
			var height = matrix.GetLength(1);

			var r = new Q[width,height];

			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					r[i, j] = new Q(matrix[i,j]);
				}
			}
			return r;
		}
		static public Q4[,] OfIntegers(int[,] matrix) {
			var width = matrix.GetLength(0);
			var height = matrix.GetLength(1);

			var r = new Q4[width,height];

			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					r[i, j] = new Q4(matrix[i,j]);
				}
			}
			return r;
		}


	}
}
