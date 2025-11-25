namespace nilnul.num.real.matrix.to_
{
	/// <summary>
	/// into <see cref="real.matrix"/>
	/// </summary>
	/// alias:
	///		split
	///				into sum
	public interface IDecompose : num.real.matrix.ITo
		,
		obj.ITo<real.IMatrix, IObjs<real.IMatrix> >
		,
		obj.to_.IToObjs
	{
	}



}
