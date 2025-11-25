namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// divide each cel by a same real number, which has to be non nil;
	///  A/x
	///  x\A
	///  ,where x is the divisor
	/// </summary>
	/// alias:
	///		shrink
	///		shred, same count of letters with scale. while shrink and stretch has more chars.
	///			,tinges with <see cref="op_.basic_.IShed"/>
	///		shard, which is used in database
	///		curtail
	///		streamline
	///		divide
	///		
	///		<see cref="nilnul.num.real.bi_.div_.IPer"/>
	///		scale down
	///		dilute <see cref="nilnul.num.real.matrix_.sq_.diag_.IInvertible"/>
	/// vs: 
	///		scale, multiply by a number, which might be nil;
	///		stretch/shed
	///		<see cref="_dilute.IStretch"/>
	///		
	/// <see cref="nilnul.num.real.matrix_.sq_.IShrinker"/>
	public interface IShrink:real.matrix.op_.scale_.IByUnnil{ }



}
