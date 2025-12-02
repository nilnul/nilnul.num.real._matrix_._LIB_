namespace nilnul.num.real.expr_.polynom.matrix_.sq.be_
{
	/// <summary>
	/// <see cref="matrix_.diag"/> but the first row and the first column are populated with some value that might be unnil;
	/// </summary>
	/// alias:
	///		×¦ÐÍ(¼ýÐÎ£©
	///		arrow
	///		claw,
	///		paw
	///			,the whole foot, including the claw
	///		talon
	///		<see cref="sq.be_."/>
	///		<see cref="sq_.sym.be_.IClaw"/>
	///		
	static public class _PawX
	{
		static public bool _IsPaw_0sq(in Algebraic[,] square)
		{

			int height = square.GetLength(0);

			for (int i = 1; i<height; i++)
			{
				int j = 1;

				for (; j <i; j++)
				{
					if (square[i, j] !=  0)
					{
						return false;
					}
				}

				for (j++; j <height; j++)
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
