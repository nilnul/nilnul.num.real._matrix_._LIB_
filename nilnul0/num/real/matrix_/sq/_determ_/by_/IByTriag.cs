namespace nilnul.num.real.matrix_.sq._determ_.by_
{
	/// <summary>
	/// <see cref="num.real.matrix.op_.triag"/>
	/// </summary>
	/// <remarks>
	///  swap would negate the determinant;
	///  shed is not necessary, as we only need a triag, not necessary an echelon
	///  
	/// </remarks>
	/// vs:
	///		by dent, we don't need it to be dent, we only need triag, even the triag is not propertly dented like:
	///			0 0 2 3
	///			0 1	 4 5
	///			0 0 5 7
	///			0,0, 0 6
	internal class IByTriag
	{
	}



}
