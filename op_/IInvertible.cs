namespace nilnul.num.real.matrix.op_
{
	/// with many such steps, we can <see cref="matrix.op_.IIndent"/>
	/// <summary>
	/// a str of <see cref="matrix.op_.IBasic"/>
	/// the result is <see cref="matrix_.IVent"/>
	/// </summary>
	/// <remarks>
	///  gaussian matrix can be put to the left, or to the right. And when it is to the left, it's <see cref="matrix.op_.IRowly"/>; otherwise, it's <see cref="op_.IColwise"/>
	/// </remarks>
	/// alias:
	///		gaussian
	///		Gauss¨CJordan elimination
	///	vs:
	///		GramSchmidt process to get orthogonal basis, where the result here is not orthogonal in general; the Gram¨CSchmidt and Gaussian elimination can both be described as taking a given basis to a special basis; Gaussian transforms the matrix by making the subspace orthonormal, and Schmidt takes the superspace into account. eg: (0,1,1) and (1,0, 1) is orthonormal in (x,y), but not ortho nor normal in (x,y,z);  
	/// 
	/// alias:
	///		gaussian
	///		IBasics

	public interface IInvertible:IOp
		,
		nilnul.obj.IStr<IBasic>
    {
    }




}
