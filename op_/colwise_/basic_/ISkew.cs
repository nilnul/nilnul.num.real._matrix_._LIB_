namespace nilnul.num.real.matrix.op_.colwise_.basic_
{
	/// <summary>
	/// unlike rowwise skew, in colwise skew, 
	/// 
	///		a x + b y
	///		=>
	///			a (x-ky +ky) + by
	///		=>  a (x+ky)  + (b-ak) y
	///		=> a x`  + (b-ak)y
	///			,where x`= x+ky, or x = x`-ky
	///			,where in b-ak, if k =a[i]\b[i], often a[i] =1 thus k = b[i],   we can have (b-ak)[i] as 0 component;
	///			
	/// ;  in matrix wise:
	///		(a,b)  (x,y)^T 
	///		= (a, b) 
	///			[
	///				1,	-k 
	///				0,	1
	///			]
	///			[
	///				1,	k 
	///				0,	1
	///			]
	///			
	///			(x,y)^T
	///		= (a,b-ak) 
	///				(x + ky, y)^T
	///		= (a, b-ak) (x`, y)^T
	///			,where x`= x+ky, or x = x`-ky
	///		
	/// </summary>
	/// <see cref="real.matrix.op_._indent.gauss_.IShed"/>
	interface ISkew:IColwise
	{
	}


}
