namespace nilnul.num.real.matrix.pred_.equat_.linear_.indent_.swoop_
{
	/// <summary>
	/// A is  <see cref="matrix_.INilful"/>;
	/// eg:
	///		1,	2 ,0   => 0
	///		0,	2, 1  => 0
	///	;
	///	where y = z /2
	///		x = -2 y= -z
	///		z are free.
	///	the solvent is in 3d space spanned by x,y,z
	///		, as a subspace of 1d, which is the intersection of the two planes
	///	;
	///	or:
	///		0z =  x +2y
	///		z = -(0x + 2y)
	///
	///     z(0,1) = x *(1,0) + y *(2,2).
	///      , the z moving along the axis freely.
	///     
	///      
	///     
	///	;
	///
	/// 
	/// 
	/// eg:
	///		1,	2 ,0 ,3 ,0  => 0
	///		0,	2, 1, 0 ,0  => 0
	///	;
	///	where x2 = (x3 )/2
	///		x1 = -3 x[4] -2 x[2]
	///		x3, x4, x5 are free.
	///	the solvent is in 5d space spanned by x1,x2,x3,x4,x5
	///		, as a subspace of 3d =5d -2d
	///	;
	///
	/// 
	/// </summary>
	/// alias:
	public interface IHomogeneous
		:ISwoop
		,
		linear_.IHomogeneous
    {
    }


}
