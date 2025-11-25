namespace nilnul.num.real.matrix_.trape_.left_.colly_
{
	/// <summary>
	/// each col is shorter if leading zero is disregarded.
	/// the transpose of <see cref="matrix_.IIndent"/>
	/// eg:
	///		[
	///			1	0	0
	///			2	3	0
	///			2	3	0
	///			2	4	5
	///		]
	/// ex:
	///		[
	///			0	0	1
	///			0	3	0
	///			2	3	0
	///			2	4	5
	///		]
	///		,which can be shuffled to make it like this;
	/// ex:
	///		[
	///			1	4	0
	///			2	3	5
	///		]
	///		,where col[1] is not lower than col[0]
	///		
	/// </summary>
	/// alias:
	///		ramp
	///		stepdown
	///		decline
	///			,not incline
	///		bear, as called in stocks
	///		wane
	///		abate
	///		fade
	///		drop
	///		recede
	///		subside
	///		slide
	///		sink
	///		dwindle
	///		cascade
	///		cataract
	public interface ICascade:trape_.ILeft
	{
	}


}
