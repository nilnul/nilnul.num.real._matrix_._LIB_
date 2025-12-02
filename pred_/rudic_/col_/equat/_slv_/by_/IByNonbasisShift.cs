namespace nilnul.num.real.matrix.pred_.rudic_.col_.equat._slv_.by_
{
	/// 
	/// <summary>
	/// with respect to: optim:linearProgramming,
	/// 
	/// Vx =b
	///		,where V is <see cref="matrix_.IVent"/>
	///	=>
	///		Iy + N z =b
	///			,where y concated with z is x. 
	///	=>
	///		Iy = b-Nz
	///	=>
	///		Iy + Iz = b +(I-N)z
	///	=>
	///		let z =I, we get y[1,1,...] = b[1,1...]-N
	///		
	///	    
	/// 
	/// 
	/// </summary>
	/// vs:
	///	    <see cref="_ByRowReductionX"/>
	///			£¬ where
	///			Vx =b
	///			Iy+Nz =b
	///		=> let z =0, we get slv:d
	///				Iy + N0 =b
	///				,we can solve d [y|0] = [b|0]
	///		then 
	///			V ( x -d  ) = b- Vd = b-b =0
	///			V y =0
	///			,we get y
	///		,then x-d =y
	///			x = d+y
	///			is the slv.
	///		,<see cref="nilnul.num.real.matrix_.vent_.indep.to_._KernelX"/>
	class IByNonbasisShift
    {
    }






}
