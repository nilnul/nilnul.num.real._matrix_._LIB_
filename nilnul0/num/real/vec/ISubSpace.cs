namespace nilnul.num.real.vec
{
	/// <summary>
	/// <see cref="vec.collective_.ISumOfScaled"/>;
	/// the linear combinations of a set of vectors;
	/// it is a collective of, often infinite, vectors
	/// </summary>
	/// alias:
	///		support
	///		span
	///			,reserved for <see cref="vec.str.ISpan"/>
	///		spread
	///	vs:
	///		<see cref="real.vecs_.IIndependent"/>, which is finite, whileas this is often infinite.
	public interface ISubSpace
		:vec.collective_.ISumOfScaled
		
	{
	}



}
