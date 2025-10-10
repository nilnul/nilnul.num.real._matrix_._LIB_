namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// divide each cel by a same real number, which has to be non nil;
	///  A/x
	///  x\A
	///  ,where x is the divisor
	/// </summary>
	/// alias:
	///		curtail
	///		streamline
	///		divide
	///		<see cref="nilnul.num.real.bi_.div_.IPer"/>
	///		scale down
	///		dilute <see cref="nilnul.num.real.matrix_.sq_.diag_.IDilutor"/>
	/// vs: 
	///		scale, multiply by a number, which might be nil;
	///		stretch/shed
	///		
	/// <see cref="nilnul.num.real.matrix_.sq_.IShrinker"/>
	public interface IShrink:real.matrix.IOp { }


}
