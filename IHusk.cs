namespace nilnul.num.real.matrix
{
	/// matrix.hull * matrix.kernel = 0
	/// ,where matrix.kernel is the kernel transposed as husk.
	/// <summary>
	/// the colspace.
	/// we need colspace for the B 
	///		in AB
	///			,where B is taken as colspace
	/// </summary>
	/// <remarks>
	/// the result of <see cref="real.matrix.rows.op_.IKernel"/>, which is still rows,  transposed as columns of a matrix.
	/// </remarks>
	/// alias:
	///		dual of rowspace
	///vs:
	///		<see cref="num.real.matrix.op_.IKernel"/>, which is intended for the husk of the resulted matrix.
	/// vs:
	///		tusk
	///		
	public interface IHusk:matrix.cols.ISpan
	{
	}


}
