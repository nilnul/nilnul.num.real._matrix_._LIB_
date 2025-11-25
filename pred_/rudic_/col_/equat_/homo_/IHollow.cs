namespace nilnul.num.real.matrix.pred_.equat_.linear_.col_.homo_
{
	/// <see cref="linear_.hollow_.IHomogeneous"/>
	/// <summary>
	/// A is 0 cols. that is t= 0. <see cref="linear_.hollow_.IHomogeneous"/>. the solvent is:
	///		[0*1]
	///
	/// eg:
	///		 R[1*0] * R[0*1]   = 0		# a unique solution: a col with 0 rows.
	///		 , this cannot be written as a form of scalars. but can be written in vectoral form, an empty row times an empty col:
	///		 
	///			[] * []^T =0
	///				, <see cref="nilnul.num.real.vec.co._DotProductX.DotProduct(ValueTuple{double, double}, ValueTuple{double, double})"/>
	///		;
	///		note: [] as 0d vec is independent, in that the determinant of [] is 1, not zero.
	///
	///  eg:
	///		if Ax = b is: 
	///		R[0*0] * R[0*1]   = R[0*1]
	///			, there is a single solution for x.

	/// 
	/// </summary>
	/// <remarks>
	/// A is 0 cols, hence A is independent.
	/// </remarks>
	class IHollow : IHomogeneous
    {
    }

}
