namespace nilnul.num.real.matrix.op_.dent_
{
	/// Some texts add the condition that the leading coefficient must be 1;  	/// <summary>
	/// some rows are nil;
	/// unnil rows are <see cref="num.real.vec_.unnil_.IStd"/>
	/// </summary>
	/// <remarks>
	///  echelon form is not unique;eg:
	///		1	,1
	///			,1
	///		can be still echelon if we skew first row by adding second row:
	///		1	,2
	///			1
	///		,geometrically we use a vect inbetween to act as a new basis.
	/// </remarks>
	/// 
	/// alias:
	///		echelon
	///			,each l or nil
	///			,etch
	///			,elemental:0,1
	///			,echElon
	///		reduced row echelon form:
	///			, (some require pivot being 1 in reduced row echelon form, not the general echelon form)

	///	vs:
	///		<see cref="op_.dent_.echelon_.IStd"/>, here we can keep the size information, which is needed in factorization to restore the original matrix by production.
	///		

	public interface IEchelon:IIndent
	{
	}



}
