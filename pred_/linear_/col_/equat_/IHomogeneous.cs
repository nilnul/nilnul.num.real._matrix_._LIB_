namespace nilnul.num.real.matrix.pred_.equat_.linear_.col_
{
	/// <summary>
	/// when B = 0
	/// ；
	///	eg:
	///		x=0
	///			# unique solution.
	///		, in that:
	///		x = 0+0
	///		R[1*0] * R[0*1] + [1] * x = 0 +0
	///		, where [1] * x = 0 has a unique solution x =0. 
	///	eg:
	///		0x =0
	///			the [0] is not independent. only [1] or any nonnil 1d vect is independent;
	///	eg:
	///		x+y =0
	///		[1]*x+ [1] * y = 0
	///		[1,1] is not fully ranked, so there is no unique solution. But there are infinite solutions, such as x=0, y=0; x=1, y=-1; x=2, y=-2; etc. The solution set is the vector which is orthogonal to the row vector [1,1].
	///		[1] and [1] are dependent.
	///	eg:
	///		x+y=0
	///		x-y=0
	///			, has a unique solution.
	///	eg:
	///		x+y=0
	///		x-y=0
	///		x+2y=0
	///			,has a unique solution. whether the solution is unique is dependent on whether the two vector, (1,1,1) and (1,-1,2) are independent.
	/// </summary>
	/// <remarks>
	/// the solution is called NullSpace/kernel for A.
	/// X is orthogonal (or perpendicular) to each of the row vectors of A
	/// </remarks>
	public interface IHomogeneous:IColumn
		,
		linear_.IHomogeneous
	{
		
	}




}
