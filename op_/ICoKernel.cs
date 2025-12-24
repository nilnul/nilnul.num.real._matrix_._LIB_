namespace nilnul.num.real.matrix.op_
{
	/// rowspace: hull
	/// row orthic: husk
	/// ;
	/// 
	/// <summary>
	///  yA =0.
	///  
	///  y is colspan's orthic complement;
	/// 
	/// </summary>
	/// <remarks>
	/// the rank of cokernel is called corank;
	/// </remarks>
	/// alias:
	///		cokernel
	///			,where 'co' tinges 'col'
	/// vs:
	///		kernel, rowspace's perpendicular complement
	///		rowspan
	///		colspan
	///		
	public interface ICoKernel: num.real.matrix.IOp 
		,
		num.real.matrix.rows.op_.IKernel
	{
	}



}
