namespace nilnul.num.real.matrix.to_
{
	/// <summary>
	/// linear span of the cols of a given matrix.
	/// It's a subspace of dimensions count of rows.
	/// it's the <see cref="matrix.op_.IRowSpan"/> of the matrix transposed.
	/// </summary>
	/// <remarks>
	/// to see whether b is in span, just <see cref="matrix.equat_.linear_.col.ISolve"/>
	/// </remarks>
	///
	/// <see cref="num.real.vecs.ILinearSpan"/>
	/// alias:
	///		columnSpace
	///		colSpace
	///		colspan
	internal class ISpan:nilnul.num.real.vecs.ILinearSpan // of the cols;
	{
	}

}
