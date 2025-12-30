namespace nilnul.num.real.matrix_.sq.factorize_
{
	/// <summary>
	/// preserver the determinant;
	///  A = PM
	///		,where P is invertible, able to be further split into basic.
	/// ; then :
	///		|A| = |P||M|
	///		,where |P| is called spinoff
	/// </summary>
	/// <see cref="num.quotient.matrix_.sq._determ_.by_._ByScaleX"/>
	/// 
	public interface IDeterminantPreserving:matrix.IFactorize
	{
	}

}
