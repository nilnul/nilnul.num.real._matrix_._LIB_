namespace nilnul.num.quotient.matrix.op_.invertible_
{
	/// <summary>
	/// eg:
	///		[
	///			0 2
	///			3 5
	///		]
	///	, we swap it but keeping the determ unchanged:
	///		[
	///			3 5
	///			0 -2
	///		]
	///		, where we negate the ancillary/auxiliary row, not the pivot row, as the ancillary row has 0 in the pivot column, and we don't need negate that cel, saving one operation.
	///		
	/// </summary>
	/// alias:
	///		sink
	///		residue
	///		sediment
	///		bury
	///		suppress
	///		
	public interface ISink:op_.IInvertible
	{
	}


}
