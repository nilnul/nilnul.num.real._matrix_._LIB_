namespace nilnul.num.real.matrix_.sq_.diag_
{
	/// <summary>
	/// at most one cels on the diagonal can have a val that is not 1
	/// eg:
	///		[]
	///		[1]
	///		[3]
	///		[0]
	///		[
	///			1,0;
	///			0,1
	///		]
	///		[
	///			1,0
	///			0,0
	///		]
	///		[1,0;0,5]
	/// </summary>
	/// <remarks>
	/// n-1 cels are 1. other cels might be not 1.
	/// one or nil cels on the diagonal are not 1.
	/// that is: all are 1, or n-1 cels are 1.
	/// 
	/// </remarks>
	/// alias:
	///		shaft
	///			like sift, shift
	///			
	///		shard
	/// <see cref="real.matrix_.sq_.IShafter"/>
	///		shred
	///			,where r means any real.
	/// vs:
	///		<see cref="real.matrix.op_.IShrink"/>
	///		sift, by divide, where divisor is not 0.
	///		<see cref="real.matrix_.sq_.diag_._shred.IUnonesOptional"/>
	public interface IShred
		:matrix_.sq_.IDiagonal
	{
	}


}
