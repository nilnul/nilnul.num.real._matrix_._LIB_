namespace nilnul.num.real.matrix_.sq_
{
	/// <see cref="real.matrix_.sq.be_._AntoSymmetricX"/>
	/// <summary>
	/// In mathematics, and in particular linear algebra, a skew-symmetric (or antisymmetric or antimetric[1]) matrix is a square matrix A whose transpose is also its negative; that is, it satisfies the equation A = ?AT. If the entry in the i?th row and j?th column is aij, i.e. A = (aij) then the skew symmetric condition is aij = ?aji. 
	/// </summary>
	/// <remarks>
	///  A[i,j] = -A[i,j], hence A[i,i] = 0
	/// </remarks>
	/// alias:
	///		antisymmetric, confusing as <see cref="nilnul.rel.be_.AntiSymmetric{T}"/>
	public interface INegSymmetric
		:ISquare
	{
		
	}


}
