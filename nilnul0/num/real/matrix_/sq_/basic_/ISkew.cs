namespace nilnul.num.real.matrix_.sq_.basic_
{
	///<see cref="matrix_.sq_.triag_.uniridge_.ISlant"/>
	/// 
	/// <summary>
	/// also a triag:<see cref="sq_.triag_.uniridge_.ISkew"/>
	/// </summary>
	/// <remarks>
	/// m[i,j] is the amplitude of the other vec.
	///  when skew is applied from left/rowwise, it changes the row[i]
	///  ;when skew is applied from right/colwise, it changes the col[j]
	/// </remarks>
	public interface ISkew:matrix_.sq_.IElemental
		,
		real.matrix_.sq_.IPlura
	{
	}

}
