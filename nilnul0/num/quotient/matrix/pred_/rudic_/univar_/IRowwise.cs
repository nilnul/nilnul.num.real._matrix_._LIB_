namespace nilnul.num.quotient.matrix.pred_.rudic_.univar_
{
	/// <summary>
	/// yA =b
	///		,where b is row: 1*n
	///		, y is 1*m
	///		,A is m*n
	///	; so, yA 1/A = b 1/A
	///			y= b/A
	/// the out put of <see cref="_pred.IScope"/> is row.
	/// </summary>
	/// alias:
	///		quota
	///			,vs<see cref="pred_.rudic_.univar_.ICol"/>
	public interface IRowwise
		:IUnivariate
	{
	}

}
