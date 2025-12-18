namespace nilnul.num.real.matrix.pred_.rudic.be_
{
	/// <summary>
	/// AX=0
	///		,where 0 might be multiple columns
	/// </summary>
	/// 
	/// alias:
	///		齐次线性方程组
	///	vs:
	///		<see cref="IUnHomogeneous"/>, Ax + b=0, where b is unnil. (if b is nil, then it's <see cref="pred_.rudic_.IHomogeneous"/>)
	public interface IHomogeneous:IRudic
	{
	}
}