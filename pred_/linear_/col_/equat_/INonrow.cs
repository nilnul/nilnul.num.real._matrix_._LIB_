namespace nilnul.num.real.matrix.pred_.equat_.linear_.col_
{
	/// <summary>
	/// when r=0;
	/// 
	///	A[0*t] * X[t*1]   = B[0*1]
	///	, where X can be, as solved,  any/arbitrary.
	/// ; but when t is 0, there is only one choice: X[0*1].
	/// , when t is 1, it's an arbitrary scalar
	/// 
	/// </summary>
	/// <remarks>
	/// the tup is {x0,x1,...xn}. the constraints are empty. That means the slv is omega.
	/// </remarks>
	public interface INonrow:equat_.linear_.INonrow
	{
		
	}



}
