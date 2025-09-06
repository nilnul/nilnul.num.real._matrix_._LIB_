namespace nilnul.num.real.matrix.op_.sel_.linear_.span_.rowwise_
{
	/// <summary>
	///  also mapping the free space.
	///  for:
	///		[ I, F ]  [ X; Y]  = B
	///		IX +FY = B
	///		IX + [G, 0  ] [ Z; W ] = B
	///			, where F is transformed to [G,0] by <see cref="matrix.op_.sel_.linear_.span_.IColwise"/>
	///
	/// 
	///  
	///  multiply from left by an invertible square matrix; the right matrix is preprocessed as a <see cref="matrix.grid_.belt_.ICols"/> of two blocs, the left of which is square invertible that is to be cancelled out. The result would be:
	///		IX = B -FY
	///		X = B-FY
	///		X = -FY + B = B -FY
	///			,which defines a subspace for [X, Y], where the count of components of Y is the dimensions to be spanned. the count of components of X is the constrained/collapsed dimensions; the dimensions of the whole space is the count of [X,Y]. in other words, Y is the augmented dimension. FY defines a free space, 
	/// 
	/// </summary>
	///
	/// <remarks>
	/// we multiply from right a matrix to transform the columns:
	///	; to make the multiplier invertible so we can move that to the other side, we need that matrix to be square.
	///	
	/// </remarks>
	/// alias:
	///	vs:
	///		coef which is <see cref="span_.IColwise"/>
	internal class IColwise
	{
	}

}
