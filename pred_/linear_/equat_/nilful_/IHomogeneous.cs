namespace nilnul.num.real.matrix.pred_.equat_.linear_.nilful_
{
	/// <summary>
	/// when B = 0.
	/// eg:
	///		[0*0] * X[0*0] =B[0*0]
	///			, the solvent is omega, which is unique
	///
	/// eg:
	///		[0*0] * X[0*1] =B[0*1]
	///			, the solvent is omega, which is unique, which is a var moving feely in 0d space.
	/// 
	///	eg:
	///		[0*1] * X[1*0] =B[0*0]
	///			, the solvent is omega, which is unique, it's a point in 1d space, as in the space 1d, there is no var to move freely.
	///			
	///	eg:
	///		[0*1] * X[1*1] =B[0*1]
	///			, the solvent is omega, which is arbitrary with freedom of 1 var (a 1d space);
	///			
	///		
	/// </summary>
	/// <remarks>
	/// the solvent is Omega.
	/// </remarks>
	public interface IHomogeneous:INilful8coef
	{
		
	}




}
