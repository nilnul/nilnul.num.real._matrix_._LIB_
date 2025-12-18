namespace nilnul.num.real.matrix_.sq.be_
{
	///		
	static public class _TridiagonalX
	{
		static public bool _IsTridiagonal_0sq(in Q4[,] square)
		{

			int height = square.GetLength(0);

			for (int i = 0; i<height; i++)
			{

				int j;	/// = 0;

				for ( j=0; j <i-1; j++)
				{
					if (square[i, j] !=  0)
					{
						return false;
					}
				}
			
				for (j+=3; j <height; j++)
				{
					if (square[i, j] !=  0)
					{
						return false;
					}
				}


			}
			return true;
		}
	}




}
