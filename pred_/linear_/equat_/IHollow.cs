namespace nilnul.num.real.matrix.pred_.linear_.equat_
{
	/// <summary>
	/// when t is 0.
	/// eg:
	///		R[n*0] * X[0*m]   = B[n*m]
	///			, one solution only when B is 0.
	/// ; when B is not 0, then there is no solution.
	/// 
	/// </summary>
	/// alias:
	///		hollow, the middle is empty.
	public interface IHollow:linear_.IEquatation
	{
		
	}


}
