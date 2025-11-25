namespace nilnul.num.real.matrix_.trape_.right_.colly_
{
	/// <summary>
	/// each col is dangling from above
	/// ;eg:
	///		[
	///			1	1	0
	///			0	2	0
	///			0	0	0
	///			0	0	3
	///		]
	///	;
	/// ;ex:
	///		[
	///		0	1	1	0
	///		0	2	0	0
	///		0	0	0	0	
	///		3	0	0	0	
	///		]
	///		,which can be made to this type by <see cref="obj.matrix.op_.shuffle_.IMirror"/>:
	///	
	///		3	0	2	0
	///		0	2	1	0
	///		0	0	1	0
	///		0	0	0	0
	///	;
	///		
	/// </summary>
	/// <remarks>
	/// transpose this into: <see cref="left_.rowwise_.ITerrace"/>. 
	/// </remarks>
	/// alias:
	///		dangle
	///		drape
	///			,like <see cref="trape_"/>
	public interface IDrape:trape_.right_.IColly
	{
	}


}
