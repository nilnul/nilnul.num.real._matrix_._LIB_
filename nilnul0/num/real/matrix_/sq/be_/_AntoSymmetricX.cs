namespace nilnul.num.real.matrix_.sq.be_
{

	/// <summary>
	/// 
	/// </summary>
	/// <inheritdoc cref="ISkewmetric"/>
	static public class _AntoSymmetricX {

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
