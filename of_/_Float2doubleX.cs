using System.Numerics;

namespace nilnul.num.real.matrix.of_
{
	static public class _Element2doubleX
	{
		static public double[,] ElAsDouble(float[,] matrix) {

			var width = matrix.GetLength(0);
			var r = new double[width,width];

			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < width; j++)
				{
					r[i, j] = matrix[i,j];
				}
			}
			return r;
		}

	}
}
