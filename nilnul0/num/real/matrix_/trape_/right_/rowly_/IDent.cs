namespace nilnul.num.real.matrix_.trape_.right_.rowly_
{
	/// <summary>
	/// each row is pushed/retracted/indented to the right.
	/// ;eg:
	///		[
	///			1	1	0
	///			0	2	0
	///			0	0	3
	///			0	0	0
	///			
	///		]
	///		
	/// ex:
	///		0	0	0	1
	///		0	0	2	1
	///		3	0	0	0
	///		,which can be shuffle_.flipped to this type:
	///		3	0	0	0
	///		0	0	2	1
	///		0	0	0	1
	///	;
	///		
	/// </summary>
	/// alias:
	///		<see cref="matrix_.IIndent"/>
	///		retract
	///		
	public interface IDent:trape_.right_.IRowly
	{
	}


}
