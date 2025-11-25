namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// cA
	/// ,multiply each cel of matrix A, by a same real number c, which can be 0;
	/// </summary>
	/// vs:<see cref="op_.rowspan_.gaussian_.IStretch"/>
	/// 
	/// vs:
	///		<see cref="matrix.co_.multible_"/>, where :
	///			<see cref="real.matrix_.ICel"/> * B, then B must be a <see cref="real.matrix_.IRow"/>
	///		or <see cref="real.matrix_.ICol"/>* <see cref="real.matrix_.ICel"/>
	///
	public interface IScale:matrix.IOp { }


}
