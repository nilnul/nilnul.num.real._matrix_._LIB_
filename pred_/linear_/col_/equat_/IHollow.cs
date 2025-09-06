namespace nilnul.num.real.matrix.pred_.equat_.linear_.col_
{
	/// <summary>
	/// when there is no unknowns shown up in the equation.
	/// eg:
	///		R[n*0] * R[0*1]   = R[n*1]
	///			, when b is 0, there is only one solution: []
	///			, otherwise, there is no solution.
	/// 
	/// </summary>
	/// <remarks>
	/// eg:
	///		R[0*0] * R[0*1]   = R[0*1]
	///			,unique solvent
	///
	/// eg:
	///		R[1*0] * R[0*1]   = R[1*1]
	///			0 =1, no solvent.
	///			or 0=0, a unique solvent
	///
	/// eg:
	///		R[2*0] * R[0*1]   = R[2*1]
	///			0 =1; 0=0;  no solvent
	///			
	///			;0=0; 0=0; a unique solvent
	/// 
	/// </remarks>
	/// A is 0 cols, hence A is independent.
	/// 
	public interface IHollow : linear_.IColumn
		,linear_.IHollow
    {
    }

}
