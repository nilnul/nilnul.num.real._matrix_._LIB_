namespace nilnul.num.real.matrix.grid_
{
	/// <summary>
	/// partition the matrix into cells.
	/// theoretically this is always feasible, and might be fun.
	/// practically this is useless.
	/// </summary>
	public interface ICels:IIsoblok { }

	static public class _CelsX
	{
		static public double[,][,] _Of(double[,] matrix) {
			 int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);
			var	r = new double[rows, cols][,];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] = new double[1, 1] { { matrix[i,j]} };
				}
			}
			return r;
		}
	}
}
