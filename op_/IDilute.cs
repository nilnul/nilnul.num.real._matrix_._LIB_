namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// A\X
	///		,where A is <see cref="matrix_.sq_.diag_.IInvertible"/>
	///		,where A is to the left to make this rowwise;
	/// </summary>
	/// <remarks>
	/// maybe this shall be studied as a <see cref="matrix.bi_._MultiX"/> rather as <see cref="matrix.IOp"/>
	/// </remarks>
	/// alias:
	///		shrink
	///		,vs stretch, which allows some nils; <see cref="matrix_.sq_.IDiagonal"/>
	public interface IDilute:real.matrix.IOp { }




}
