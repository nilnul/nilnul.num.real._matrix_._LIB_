namespace nilnul.num.real.matrix.pred_.equat_.linear_.col_.hollow_
{
	/// <summary>
	///	where n is positive:
	///		R[n*0] * R[0*1]   = R[n*1]
	///			, when b is not 0,  there is no solution.
	///	eg:
	///		R[1*0] * R[0*1]   = R[1*1], which is not 0
	///			0 =1, no solvent.
	/// </summary>
	/// <remarks>
	/// no solvent
	/// 
	/// </remarks>
	///

	public interface IUnHomogeneous
		:matrix.pred_.equat_.linear_.col_.IHollow
	{ }
}
