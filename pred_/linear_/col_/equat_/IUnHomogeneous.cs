namespace nilnul.num.real.matrix.pred_.equat_.linear_.col_
{
	/// <summary>
	///  A can be regarded as cols. Hence Ax is a linear combination of those cols. If b is in the subspace spanned by those cols (b is 0, when the subspace is 0), then there is some solution; otherwise, there is no solution.

	///	eg:
	///		0x =1
	///			no solution, as 1 is not in the space spanned by [0]
	/// eg:
	///		x =1
	///			,there is a solution, as 1 is in the space spanned by cols.
	///			, the solution is unique, as the cols are independent.
	///	eg:	 
	///		{
	///			x =1, 
	///			x =2
	///		}	# no solution. R[2*1] * R[1*1] = [1;2]	# no solution.
	///	;

	/// </summary>
	/// <remarks>
	/// </remarks>

	public interface IUnHomogeneous:IColumn
		
	{
		
	}




}
