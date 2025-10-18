namespace nilnul.num.real.matrix_
{
	/// <summary>
	/// the matrix is <see cref="real.matrix.be_.IIndent"/>
	/// </summary>
	/// <remarks>
	/// right trape matrix is not necessarily indent, as demonstrated by an example:
	///		1,0,0,0,0
	///		0,0,0,0,1
	///		0,0,0,1,0
	/// </remarks>
	/// alias:
	///		<see cref="real.matrix_.trape_.IRight"/>
	///		indent
	///			,dent, in comparison with vent
	///		inden, meaning "in den", where den is a den/nest
	public interface IIndent
		:trape_.IRight		/// not <see cref="trape_.ILeft"/>, but <see cref="trape_.IRight"/> cuz in right the first row is more likely unnil while the last row is more likely nil.
    {
    }



}
