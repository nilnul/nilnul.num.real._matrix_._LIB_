using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.to_
{
	/// eg:
	///		for
	///			{
	///				1,0,0
	///			}, the space is 3d, and the rowspan is 1d.
	///		, the kernel is :
	///			{
	///				0,1,0
	///				0,0,1
	///			}, which are the subspace that are orthic to the rowspan.
	///	
	/// eg:
	///		for
	///			{
	///				1,0,0
	///				0,1,0
	///			}, the space is 3d, and the rowspan is 2d.
	///		, the kernel is :
	///			{
	///				0,0,1
	///			}, which are the subspace that are orthic to the rowspan.
	/// eg:
	///		for
	///			{
	///				1,0,0
	///				0,1,0
	///				0,0,1
	///			}, the space is 3d, and the rowspan is 3d.
	///		, the kernel is :
	///			{
	///				
	///			}, which are the subspace that are orthic to the rowspan.
	///	
	/// eg:
	///		for
	///			{
	///			}, the space is 3d, and the rowspan is 0d.
	///		, the kernel is :
	///			{
	///				1,0,0
	///				0,1,0
	///				0,0,1
	///				
	///			}, which are the subspace that are orthic to the rowspan.
	/// ;<see cref="pred_.linear_.col_.IEquation"/> is to find the kernel.
	/// <summary>
	/// the set of all vectors that, when multiplied by the matrix, result in zero vector.
	/// the result is a space, representable by a matrix, but not a matrix. Actually it can be represented by many matrices that are equivalent:<see cref="matrix.re_.IEquiv"/>
	/// ;
	/// the dimensions count is cols of the original matrix.
	/// </summary>
	/// <remarks>
	/// Null(A) is all the vectors in the domain that are sent to zero by the transformation.
	/// </remarks>
	/// alias:
	///		kernel
	///		nullspace
	///		null space
	///	vs:
	///		<see cref="real.matrix_.sq.IEigen"/>, whichs scale the matrix when the matrix is transformed by the matrix.
	///		<see cref="num.real.matrix.rows.ILinearCombinate"/>
	/*public*/ interface IKernel: num.real.vecs.ILinearSpan
	{
	}


}
