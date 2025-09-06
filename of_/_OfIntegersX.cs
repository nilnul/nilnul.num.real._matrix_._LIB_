using System.Numerics;

namespace nilnul.num.real.matrix.of_
{
	static public class _OfIntegersX
	{
		static public nilnul.num.RealI[,] OfIntegers(BigInteger[,] matrix) {
			var width = matrix.GetLength(0);
			var height = matrix.GetLength(1);

			var r = new RealI[width,height];

			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					r[i, j] = new nilnul.num.real_.Quotient(matrix[i,j]);
				}
			}
			return r;
		}
	}
}
