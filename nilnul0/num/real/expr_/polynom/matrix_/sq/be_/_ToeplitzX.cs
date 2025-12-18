namespace nilnul.num.real.expr_.polynom.matrix_.sq.be_
{
	///		
	static public class _ToeplitzX
	{
		static public bool _IsToeplitz_0sq(in Algebraic[,] square)
		{

			int height = square.GetLength(0);

			for (int i = 0; i<height; i++) /// the first row:
			{
				var pargon = square[0, i];

				for (int r = 1, c = 1+i; /*r < height &&*/ c<height; r++, c++)
				{

					if (square[r, c] !=  pargon)
					{
						return false;
					}
				}

			}
			for (int i = 1; i<height; i++) /// the first col:
			{
				var pargon = square[ i,0];

				for (int c = 1, r = 1+i; r < height /*&& c<height*/; r++, c++)
				{

					if (square[r, c] !=  pargon)
					{
						return false;
					}
				}

			}


			return true;
		}
	}




}
