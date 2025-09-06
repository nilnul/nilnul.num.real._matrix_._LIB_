using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.to_.decom_
{
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
	/// 
	/// </remarks>
	/// alias:
	///		svd, the three factor can be denoted as: S,V,D
	///			,where V is diagonal.
    class ISingularValueDecomposition
    {
    }
}
