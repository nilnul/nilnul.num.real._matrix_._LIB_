namespace nilnul.num.real.matrix.op_.indent_
{
	/// Some texts add the condition that the leading coefficient must be 1;  	/// <summary>
	/// some rows are nil;
	/// unnil rows are <see cref="num.real.vec_.unnil_.IStd"/>
	/// </summary>
	/// 
	/// alias:
	///		echelon
	///			,each l or nil
	///			,etch
	///			,elemental:0,1
	///		reduced row echelon form:
	///			, (some require pivot being 1 in reduced row echelon form, not the general echelon form)

	///	vs:
	///		<see cref="op_.indent_.echelon_.IStd"/>, here we can keep the size information, which is needed in factorization to restore the original matrix by production.
	///		

	public interface IEchelon:IIndent
	{
	}



}
