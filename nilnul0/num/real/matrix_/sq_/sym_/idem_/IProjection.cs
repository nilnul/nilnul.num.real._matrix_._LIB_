namespace nilnul.num.real.matrix_.sq_.sym_.idem_
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
	/// rank at n-1 or less.
	/// </summary>
	/// the rank cannot be nil, <see cref="nilnul.num.real.vec.op_._proj_.IBasis"/> which is unnil.
	/// 
	/// 
	/// alias:
	///		projection matrix
	public interface IProjection
		:sq_.sym_.IIdempotent
		,
		sq_.IUnInvertible
	{
	}


}
