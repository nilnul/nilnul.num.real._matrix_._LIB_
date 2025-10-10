namespace nilnul.num.real.matrix_.sq_.sym_
{
	/// we need
	///		Px = PP x
	///		, for any col: x.
	///	and we also need, for any col:x,y
	///		Px . y = x . Py = Px . Py
	///		,that is:
	///			(Px)^T y = x^T P y = (Px)^T (Py)^T
	///			x^T P^T y = x^T P y
	///		, where P^T = P
	/// <summary>
	/// <see cref="matrix_.sq.be_.IIdempotent"/>
	/// </summary>
	/// alias:
	public interface IIdempotent
		:sq_.ISymmetric, sq_.IIdempotent
	{
	}


}
