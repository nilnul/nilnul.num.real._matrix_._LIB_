namespace nilnul.num.real.vecs
{
	/// <summary>
	/// 
	/// if the coefficients are all unnegative, and summed as one (as required by <see cref="IAffine"/>).
	///		
	/// </summary>
	/// <remarks>
	/// This is equivalent to a weighted average where all weights are non-negative. 
	/// 
	/// this is often defined as points in geometry
	/// </remarks>
	/// alias:
	///		hull
	///	vs:
	///		simplex
	public interface IConvex:ISubspatial,IAffine
    {
    }




}
