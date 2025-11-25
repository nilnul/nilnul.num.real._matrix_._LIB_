namespace nilnul.num.real.matrix.pred_.equat_.linear_
{
	/// <summary>
	/// AX=B[r*c], where c is plural.
	/// ;
	/// X is [t*c], like [X1, X2, ... Xc]
	/// , hence, the equation is equivalent to a set of equations:
	/// 
	/// AX1 = B1
	/// AX2 = B2
	/// ,
	/// ...
	/// ,AXc=Bc
	/// , each of which is a <see cref="IColumn"/>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// So it's a set/sys/system of <see cref="IColumn"/>
	///
	/// 
	public interface IPluralColumns
		:matrix.pred_.equat_.ILinear
	{ }
}
