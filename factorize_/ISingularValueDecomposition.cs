using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.factorize_
{
	/// decomposed as SVD
	///		,where V, a diagonal, can be further decomposed as:
	///			AB
	///			,where A as <see cref="real.matrix_.IDiagonal"/> can be further devided as <see cref=""/>
	///		,where S,D are <see cref="num.real.matrix_.sq_.IOrthoNormal"/>
	/// ; this is a way to sqrt (<see cref="real.matrix.op_.sym_.IEndoMul"/>)
	/// 
	/// 
	///  for matrix M
	///  ,M M^T
	///  , solve its eigenvalues;
	///  , sqrt the eigenvalues;
	/// 
	/// <summary>
	/// singular value decomposition;
	/// If M is real, then U and V can be guaranteed to be real orthogonal matrices; in such contexts, the SVD is often denoted UΣV^T.
	/// The SVD is not unique. However, it is always possible to choose the decomposition such that the singular values 	Σ[i,i] are in descending order. In this case, Σ (but not U and V) is uniquely determined by M.
	/// </summary>
	/// <remarks>
	///One-sided Jacobi algorithm
	///;
	///Two-sided Jacobi algorithm
	/// ;
	/// as this involves eigen values, see <see cref="nilnul.num.complex.matrix"/>
	/// </remarks>
	/// 
	/// 
	/// 
	/// alias:
	///		svd, the three factor can be denoted as: S,V,D
	///			,where V is diagonal
	///			, where S is orthonormal (rotation or reflect)
	///			, where D is orthonormal (rotation or reflect)
	///		; this means a morph by matrix can be composed from 3 morphs: the rigid, the stretch, the rigid
	///		generalized diagonalization
	///			
	class ISingularValueDecomposition
    {
    }

}
