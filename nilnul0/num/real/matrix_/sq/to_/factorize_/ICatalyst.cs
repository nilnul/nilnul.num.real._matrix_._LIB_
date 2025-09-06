namespace nilnul.num.real.matrix_.sq.to_.factorize_
{
	/// <summary>
	/// AV = VD
	/// ,where V might be singular.
	/// AV as the matrix to be factorized. and the rightside is still a product. But the product VD has V as the byproduct/coproduct, and D as the main/prime product.
	/// </summary>
	/// <remarks>
	/// even allowing V to be singular, we might still unable to find a diagonal. rather, we can find a tridiagonal when we encounter complex eigenval, as being studied later in <see cref="nilnul.num.complex.matrix"/>
	/// </remarks>
	public interface ICatalyst:IFactorize
	{
	}


}
