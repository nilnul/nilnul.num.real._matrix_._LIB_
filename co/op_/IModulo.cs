namespace nilnul.num.real.matrix.co.op_
{
	/// <see cref="real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX"/>
	/// <summary>
	/// get the quotient and remainder. 
	/// eg:
	///		Ax=b
	///		x = A\b = husk + drift = husk ... drift *A, where husk is the quotient, drift*A is the remainder.
	/// </summary>
	/// 
	/// vs:
	///		<see cref="IDivide"/> ,which returns not (quotient,remainder), but a fractional reprsented by a co separated by '\' :  A\b = GA\Gb, where G is the common multiplier, <see cref="real.matrix.op_.IGaussian"/>
	///		model
	///		module
	///	;
	///	<see cref=""/>
	public interface IModulo:co.IOp { }
}
