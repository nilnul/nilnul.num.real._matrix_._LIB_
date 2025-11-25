namespace nilnul.num.real.matrix_.sq_.orient.op_
{
	/// <summary>
	/// negate one cel from 1 to -1; keep other cels unchanged.
	/// eg:
	///		[
	///			-1
	///		]
	///		[
	///			1,0,0
	///			0,-1,0
	///			0,0,1
	///		]
	/// </summary>
	/// <remarks>
	/// this will change the <see cref="orient.be_.IProhand"/>
	/// </remarks>
	/// alias:
	/// antipodal;
	/// antipolarize
	/// oppolarize
	/// 
	/// vs:
	///		repolarize, may negate or keep intact
	public interface INegateOneCel { }
}
