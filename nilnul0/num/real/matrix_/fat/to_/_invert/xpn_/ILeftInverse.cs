namespace nilnul.num.real.matrix_.fat.to_
{
	/// <summary>
	/// a fat matrix has no left inverse.
	/// eg:
	///		[
	///			x
	///			y
	///		] [a,b] =I
	///		,then 
	///		[
	///			xa, xb
	///			ya, yb
	///		] is degenerate:<see cref="real.matrix_.IDependent"/>, and it cannot be I.
	/// </summary>
	public interface ILeftInverse
	{
	}


}
