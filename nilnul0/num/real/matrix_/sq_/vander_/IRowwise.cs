namespace nilnul.num.real.matrix_.sq_.vander_
{
	/// <summary>
	/// [
	///		1	,1	,1
	///		x	x1,	x2
	///		x^2 ,x1^2,x2^2
	///	]
	///	=A
	///	, hence 
	///	[a,b,c] A  = [y,y1,y2]
	///		[a,b,c] = [y,y1,y2]/A
	///		,gives us the coefficients of the original polynomial:
	///			a for degree 0
	///			b for degree1
	///			c for degree2
	/// </summary>
	/// <remarks>
	///  transposal of <see cref="IColwise"/>
	/// </remarks>
	public interface IRowwise:IVandermonde
	{
	}


}
