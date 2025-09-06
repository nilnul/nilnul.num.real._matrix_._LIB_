namespace nilnul.num.real.matrix_.sq.be_
{
	/// <summary>
	/// eg:
	///		[]
	///		[1]
	///		
	/// </summary>
	static public class _CanonicalX
	{

		/// <summary>
		/// </summary>
		/// <param name="sq"></param>
		/// <returns></returns>
		static public bool _Be_0square(Q[,] sq)
		{
			int rows = sq.GetLength(0);

			for (int i = 0; i < rows; i++)
			{
				int j = 0;
				for (; j < i; j++)
				{
					if (sq[i, j] != 0)
					{
						return false;
					}
				}


				if (sq[i, i] != 1)
				{
					return false;
				}


				for (; j < rows; j++)
				{
					if (sq[i, j] != 0)
					{
						return false;
					}
				}



			}
			return true;
		}



	}



}
