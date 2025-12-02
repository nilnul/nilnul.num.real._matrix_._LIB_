namespace nilnul.num.real.expr_.polynom.matrix_.sq.be_
{
	///		
	static public class _SymmetricX
	{
		static public bool _IsSymmetric_0sq(in Algebraic[,] square)
		{

			int height = square.GetLength(0);

			for (int i = 1; i<height; i++)
			{

				for (int j = 0; j <i; j++)
				{
					if (square[i, j] !=  square[j,i])
					{
						return false;
					}
				}



			}
			return true;
		}
	}




}
