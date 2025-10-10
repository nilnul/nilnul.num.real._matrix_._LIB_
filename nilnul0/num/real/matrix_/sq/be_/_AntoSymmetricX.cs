namespace nilnul.num.real.matrix_.sq.be_
{
	/// <summary>
	/// the diagonal can be nonnil.
	/// </summary>
	/// <remarks>
	///  used as <see cref="real.matrix_.sq_.ii_.INegSym"/>, which is <see cref="matrix_.sq_.ii.IRotate"/>
	/// </remarks>
	/// <see cref="sq.ske"/>
	/// alias:
	///		antisym, like <see cref="nilnul.rel_.IAntisym"/> where reflexive/diagonal cels are disregarded.
	///		antisymmetric
	///		antimetric
	///		antometric
	///			,altmetric
	///		negsym
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
