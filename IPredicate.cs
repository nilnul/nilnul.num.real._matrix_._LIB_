namespace nilnul.num.real.matrix
{
	/// <summary>
	/// a predicate taking <see cref="real.IMatrix"/> as unknowns.
	/// eg:
	///		X+AY = Z^2
	///		AX != 0
	///		AX > 0
	/// </summary>
	/// <remarks>
	/// then we can solve the predicate by finding the set of <see cref="real.IMatrix"/> that satisfies the predicate.
	/// </remarks>
	public interface IPred
		:nilnul.obj.IPred///<real.IMatrix>
		///,nilnul.obj.IPredicate
	{ }




}