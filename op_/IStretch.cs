namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// AX
	///		,where A is <see cref="matrix_.sq_.IDiagonal"/>,which means each cel at diagonal can be nil. Here we multiply, rather divide.
	///		, where X is the input
	///	; 
	///	A is to the left, as this is rowwise(<see cref="op_.IRowly"/>) operation.
	/// </summary>
	/// <remarks>
	///  multiply means 0 is allowed; to not allow 0, <see cref="op_.dilute_.IByMultiInverse"/>
	/// </remarks>
	/// alias:
	///		stretch, the antonym of <see cref="op_.IShrink"/>
	///			,<see cref="real.matrix_.sq_.IDiagonal"/>
	///		spread
	///		shred
	public interface IStretch:real.matrix.IOp { }



}
