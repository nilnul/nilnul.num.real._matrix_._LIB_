namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// convert it to another size:
	/// by truncate or pad
	/// </summary>
	/// 
	public interface ISizing { }

	static public class _SizingX
	{
		static public Q4[,] _Size_0rows_1cols(int rows, int cols, Q4[,] matrix)
		{
			var h = matrix.GetLength(0);
			var w = matrix.GetLength(1);

			var o = new Q4[rows, cols];
			for (var i = 0; i < rows; i++)
			{
				for (var j = 0; j < cols; j++)
				{
					o[i, j] =  (i<h && j<w) ? matrix[i, j] : 0;
				}
			}
			return o;

		}
	}
}
