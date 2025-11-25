namespace nilnul.num.real.matrix_.trape_.left_.rowwise_
{
	/// <summary>
	/// each row is longer. there is at most one step height.
	/// eg:
	///		[
	///			1	0	0
	///			2	4	5
	///		]
	///		
	/// eg:
	///		[
	///			1	4	0
	///			2	4	5
	///		]
	/// eg:
	///		[
	///			1	4	0
	///			2	3	5
	///		]
	///		
	/// </summary>
	/// <remarks>
	///  <see cref="nilnul.obj.matrix.op_.rowwise_.IFlip"/> this to make it <see cref="real.matrix_.IIndent"/>
	/// </remarks>
	/// alias:
	///		protrude
	///		stepdown
	///		terrace
	///			,which must be viewed above, as viewed below the above terrace cannot be seen;
	///		gradient
	///		descent
	///		stairdown
	///		stepdown
	/// vs
	///		retract

	public interface ITerrace:trape_.ILeft
	{
	}


}
