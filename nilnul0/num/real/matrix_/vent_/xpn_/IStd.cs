namespace nilnul.num.real.matrix.op_.dent_.echelon_.vent_.xpn_
{
	/// <see cref="real.matrix.op_.dent_.echelon_.vent_"/>, with zero rows appended.
	/// 
	/// <summary>
	/// <see cref="nilnul.num.real.matrix_.vent.op_.IStd"/>
	/// </summary>
	/// <remarks>
	/// eg:
	///		[
	///			0,1,0,0,1
	///			0,0,1,0,1
	///		]
	///			,where the col0 is zero, meaning c0 can not replace c1 or c2
	///			, col3 is zero , and it cannot replace c1 or c2;
	///			, col4 is unzero, meaning it can be licominated by c1,c2 (every zero or unzero col can be licominated by c1,c2 ), but c1,c2 c4 can remove any one, we keep c1,c2, just cuz it appears earlier.
	///			, c4 meaning binding two rows by 1 and 1, hence it's line segment in the rowspan; c0,c3 meaning zero on the rowspan.
	///			
	/// ;
	///		[
	///			0,1,0,0,0,1,0
	///			0,0,0,1,0,1,0
	///		]
	///		,where cel01 is not influenced by cel00, but is influenced by cel05
	/// 
	/// </remarks>
	/// 
	/// <see cref="real.matrix.op_.dent_.echelon_.indep_._VentX"/>
	/// alias:
	///		<see cref="real.matrix.IHull"/>
	///		<see cref="real.matrix.op_.IHull"/>
	///		regular, 'r' tinges row.
	///		canonical, which may also involves colwise operation such that the spanning left upper canonical square appears as leftupward as possible, like:
	///			[1,0,0,1,0
	///			 0,1,0,1,0]
	///		
	public interface IStd
		:
		//matrix.IOp
		//,
		matrix.op_.IHull
	{
	}


}
