namespace nilnul.num.quotient.matrix_.sq.be_
{
	/// <see cref="nilnul.num.quotient.matrix_.sq_.va"/>
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="nilnul.num.real.matrix_.sq.be_."/>
	/// <see cref="nilnul.num.real.matrix_.sq_._VandermondeX"/>
	public interface IVandermonde:sq.IBe { }

	static public class _VandermondeX 
	{
		static public bool IsColwiseVanderMonde(in Q4[,] square) {
			int height = square.GetLength(0);
			if (height==1)
			{
				return square[0,0]==1;
			}

			for (int i = 0; i < height; i++)
			{
				/// height is plura.
				if (square[i,0]!=1)
				{
					return false;
				}
				var x = square[i, 1];
				var p = x;

				for (int j = 2; j < height; j++)
				{

					if (square[i,j]!= (p*=x))
					{
						return false;
					}
				}
			}
			return true; 
		
		}
	}


}
