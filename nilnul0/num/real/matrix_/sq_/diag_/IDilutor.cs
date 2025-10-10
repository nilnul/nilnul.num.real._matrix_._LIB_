namespace nilnul.num.real.matrix_.sq_.diag_
{
	/// <summary>
	/// each diagonal cel is unnil.
	/// </summary>
	/// <remarks>
	/// denote this as A, 
	/// then we can do B/A, or A\B, which is B * 1/A, where 1/A is the scaler. but here this ensures no nil is on the diagonal.
	/// </remarks>
	/// alias:
	///		divisor
	///		dilute,where 'd' leas divisor and diag
	public interface IDilutor
		:
		nilnul.num.real.matrix_.sq_.IDiagonal
			//nilnul.num.integer.matrix
	{
	}



}
