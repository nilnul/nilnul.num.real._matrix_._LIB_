namespace nilnul.num.real.matrix_.std_
{
	/// <summary>
	/// <see cref="real.matrix_.IPortrait"/>
	/// </summary>
	static public class _PortraitX
	{
		static public Q[,] _OfRowsCols_2rank(
			int rows
			,
			int cols
			,
			int rank
		)
		{
			var r = new Q[rows, cols];

			var col = 0;

			for (; col < rank; col++)
			{

				var row = 0;

				while (row<col)
				{
					r[row++, col] =0;
				}

				/// here col might be greater than rows-1, . but as this is portrait, 
				r[row++, col] = 1;

				while (row<rows)
				{
					r[row++, col] = 0;
				}
			}

			for (; col <cols; col++)
			{
				for (int i = 0; i < rows; i++)
				{
					r[i, col] =0;
				}

			}
			return r;
		}
	}
}
