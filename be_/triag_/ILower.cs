namespace nilnul.num.real.matrix.be_.triag_
{
	/// <summary>
	/// only the lower part is non-zero, and the diagonal can be anything, 0 or not;
	/// eg:
	///		{
	///			1,0,0,0,0;
	///			0,0,0,0,0;
	///			1,0,2,0,0;
	///		}
	/// eg:
	///		{
	///			1,0,0;
	///			0,0,0;
	///			1,0,2;
	///			0,1,0
	///		}
	/// 
	/// </summary>
	public interface ILower:be_.ITriangular
	{
	}

}
