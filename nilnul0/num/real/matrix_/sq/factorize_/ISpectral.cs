using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.to_.factorize_
{
	/// <summary>
	/// S = Q D Q^T
	///		,where Q is orthonormal matrix, D is diagonal.
	///	;
	///	if S is symmetric, then it can always be decomposed this way:
	///		Q will be the eigenvecs. D will be the eigenvals.
	///		
	/// ; in Q, eigen vec can be negated to make Q a conservative handness rotation (no flipping involved, especially significant in 3d space).
	/// </summary>
	/// <remarks>
	///  not always possible for a arbitrary matrix.
	/// </remarks>
	internal class ISpectral
	{
	}
}
