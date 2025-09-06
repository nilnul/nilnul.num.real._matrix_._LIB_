namespace nilnul.num.real.matrix_.sq.be_
{
	static public class _SymmetricX {

		/// <summary>
		/// if A = A^T
		/// </summary>
		/// <param name="sq"></param>
		/// <returns></returns>
		static public bool _Be_0square(double[,] sq) {
			int rows = sq.GetLength(0);
			for (int i = 0; i < rows; i++)
			{
				for (int j = i+1; j < rows; j++)
				{
					if (sq[i,j] != sq[j,i] )
					{
						return false;
					}
					
				}
			}
			return true;
		}

		static public bool _Be_0square(int[,] sq) {
			int rows = sq.GetLength(0);
			for (int i = 0; i < rows; i++)
			{
				for (int j = i+1; j < rows; j++)
				{
					if (sq[i,j] != sq[j,i] )
					{
						return false;
					}
					
				}
			}
			return true;
		}

		static public bool _Be_0square(Q[,] sq) {
			int rows = sq.GetLength(0);
			for (int i = 0; i < rows; i++)
			{
				for (int j = i+1; j < rows; j++)
				{
					if (sq[i,j] != sq[j,i] )
					{
						return false;
					}
					
				}
			}
			return true;
		}



	}



}
