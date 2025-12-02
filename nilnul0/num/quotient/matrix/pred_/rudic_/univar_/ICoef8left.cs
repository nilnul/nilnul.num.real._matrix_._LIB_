namespace nilnul.num.quotient.matrix.pred_.rudic_.univar_
{
	/// <summary>
	/// Ax =b
	///		then A\1 Ax = A\1 b
	///		x = A\b
	/// </summary>
	/// <remarks>
	///  b might contain plura columns, so this is innudating <see cref="ICol"/>
	/// </remarks>
	/// alias:
	///		quota, as x=A\b
	public interface ICoef8left
		:IUnivariate
	{

	}


}
