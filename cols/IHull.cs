namespace nilnul.num.real.matrix.cols
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
	/// <see cref="num.real.vecs.IHull"/>
	/// alias:
	///		columnSpace
	///		colSpace
	///		colspan
	///		hull
	///		husk, the hull of cols
	public interface IHull:nilnul.num.real.vecs.IHull // of the cols;
	{
	}


}
