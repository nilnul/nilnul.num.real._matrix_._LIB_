namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// a linear map (also called a linear mapping, linear transformation, vector space homomorphism, or in some contexts linear function) is a mapping V→W between two vector spaces that preserves the operations of vector addition and scalar multiplication.
	/// </summary>
	/// <remarks>
	/// for u,v in old [rows*cols] matrix, 
	///		f(u+v) = f(u) + f(v)
	///		f(cu) = cf(u), where c is a scalar
	///	; f( [rows*cols]) = [r1*c1]
	///	eg:
	///		scaling
	///	ex:
	///		x->x^2
	///		x->x +1, which is affine instead.
	/// </remarks>
	public interface IHomomorphism:matrix.IOp
	{
	}


}
