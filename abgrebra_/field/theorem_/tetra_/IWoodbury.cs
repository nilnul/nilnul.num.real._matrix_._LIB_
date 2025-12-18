using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.abgrebra_.field.theorem_.tetra_
{
	///en.wikipedia.org/wiki/Woodbury_matrix_identity#Binomial_inverse_theorem
	/// <summary>
	/// 
	/// (A+UCV)\1 = A\ - A\U  (C\ + VA\U)\V A\
	///		= A\ -A\ UB (B+BVA\UB)\ BVA\
	///		= A\ -A\ U(I+BVA\U)\ BVA\
	///		,where each matrix is conformable.
	/// </summary>
	/// <remarks>
	/// proof:
	///		by multiply both sides with A+UCV
	/// corollary:
	///		(A+B)\  = A\ - (A + AB\A)\
	///				= A\ - A\ (AB\ + I)\
	///			
	///		
	/// </remarks>
	/// 
	internal class IWoodbury
	{
	}
}
