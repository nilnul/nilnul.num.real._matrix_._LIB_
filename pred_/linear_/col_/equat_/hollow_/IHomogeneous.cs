namespace nilnul.num.real.matrix.pred_.equat_.linear_.col_.hollow_
{
	/// <summary>
	///		R[n*0] * R[0*1]   = R[n*1]
	///			, when b is 0, there is only one solution: []
	/// </summary>
	/// <remarks>
	///  eg:
	///		if Ax = b is: 
	///		R[0*0] * R[0*1]   = R[0*1]
	///			, there is a single solution for x.
	///	 eg: 
	///		R[1*0] * R[0*1]   = R[1*1], which is 0
	///			or 0=0, a unique solvent
	/// 
	/// </remarks>

	public interface IHomogeneous
		:matrix.pred_.linear_.col_.equat_.IHollow
	{ }
}
