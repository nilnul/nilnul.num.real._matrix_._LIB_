namespace nilnul.num.real.matrix_
{
	/// <summary>
	/// n*1
	/// ; eg:
	///		
	///		 1
	///		 2
	///		 3
	///	, vertically
	/// </summary>
	/// <remarks>
	/// for linear equation set, the righthand side is a col.
	///
	///  R[m,n] * R[n,1] = R[m,1]
	///  , when n = 0:
	///  R[m,0] * R[0,1] = R[m,1] , which is all nils.
	///  , when n =1:
	///  R[m,1] * R[1,1] = R[m,1] , which is a scaled R[m,1]
	///  
	/// </remarks>
	public interface ICol
		:nilnul.obj.matrix_.ICol
		,ILinear
	{
	}
}
