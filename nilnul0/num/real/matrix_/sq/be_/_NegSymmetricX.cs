namespace nilnul.num.real.matrix_.sq.be_
{
	/// <summary>
	/// if A^T = -A, then A is neg-symmetric.
	/// </summary>
	/// <see cref="sq.ske"/>
	static public class _NegSymmetricX {

		static public bool Be(double[,] sq) {
			int rows = sq.GetLength(0);
			for (int i = 0; i < rows; i++)
			{
				for (int j = i+1; j < rows; j++)
				{
					if (sq[i,j] != -sq[j,i] ) /// the two sums to 0
					{
						return false;
					}
					
				}
			}
			return true;
		}


	}



}
