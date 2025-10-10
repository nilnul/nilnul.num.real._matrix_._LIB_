namespace nilnul.num.real.matrix_.sq_.diag_
{
	/// <summary>
	/// the cels that are not 1, are at most 1. 
	/// eg:
	///		[]
	///		[1]
	///		[3]
	///		[0]
	///		[1,0;0,1]
	///		[1,0;0,5]
	/// </summary>
	/// <remarks>
	/// n-1 cels are 1. other cels might be not 1.
	/// one or nil cels on the diagonal are not 1.
	/// that is: all are 1, or n-1 cels are 1.
	/// 
	/// </remarks>
	/// <see cref="real.matrix_.sq_.IShafter"/>
	public interface IUnonesOptional
		:matrix_.sq_.IDiagonal
	{
	}


}
