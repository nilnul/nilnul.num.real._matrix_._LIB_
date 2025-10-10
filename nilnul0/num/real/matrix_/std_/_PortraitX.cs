namespace nilnul.num.real.matrix_.std_
{
	/// <summary>
	/// <see cref="real.matrix_.IPortrait"/>
	/// </summary>
	static public  class _PortraitX
	{
		static public Q[,] OfRowsCols(
			int rows
			,
			int cols
		) { 
			var r = new Q[rows, cols];

			for ( var col = 0; col < cols; col++ ) {

				var row = 0;

				while (row<col)
				{
					r[row++,col] =0;
				}
	
				/// here col might be greater than rows-1, . but as this is portrait, 
				r[row++, col] = 1;

				while (row<rows)
				{
					r[row++, col] = 0;
				}
			}
			return r;
		}
	}
}
