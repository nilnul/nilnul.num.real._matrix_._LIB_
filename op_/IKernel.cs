using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_
{
	/// kernel is defined as an operation rather than a collective of equivalent matrices.
	/// 
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
	/// ;<see cref="pred_.rudic_.col_.IEquation"/> is to find the kernel.
	/// 
	/// 
	/// 
	/// the preimg/srcs that are transformed into 0 in the target space.
	/// eg:
	///		Ax = 0
	///		,where A is the <see cref="matrix.IOp"/>, the solvent is kernel.
	///		; given A, we get x, and that is called kernel the operation.
	/// 
	/// <summary>
	/// the set of all vectors that, when multiplied by the matrix, result in zero vector.
	/// the result is a space, representable by a matrix, but not a matrix. Actually it can be represented by many matrices that are equivalent:<see cref="matrix.re_.IEquiv"/>
	/// ;
	/// the dimensions count is cols of the original matrix.
	/// </summary>
	/// 
	/// another hull in the same space, but perpendicular. kernel is colwise to emphasize it's perpendicular, not aligned as the hull;
	/// <remarks>
	/// 
	/// 
	/// Null(A) is all the vectors in the domain that are sent to zero by the transformation.
	/// </remarks>
	/// 
	/// 
	/// alias:
	///		kernel
	///			,ker
	///			, the preimg/src of 0s in the target of the <see cref="matrix.op_.IMultiply"/>
	///		husk
	///			,<see cref="matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX._Solve_0indepVent(quotient_.DenomNonnil[,])"/>
	///		nullspace
	///		null space
	///			,vs:<see cref="IRowSpan"/> which is also called <see cref="matrix.rows.op_.IHull"/>
	///	vs:
	///		<see cref="real.matrix_.sq.IEigen"/>, whichs scale the matrix when the matrix is transformed by the matrix.
	///		<see cref="num.real.matrix.rows.IHull"/>
	///	
	/// <see cref="num.real.matrix.to_.IKernel"/>
	/// 
	/// <see cref="num.real.matrix.op_._husk_.by_._ByRowReductionX"/>
	public interface IKernel: num.real.matrix.IOp 
	{
	}


}
