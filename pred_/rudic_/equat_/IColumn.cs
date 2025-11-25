using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.pred_.rudic_.equat_
{
	/// A x =b, where x is a column vector, A is a matrix, and b is a col.
	/// <summary>
	/// for AX=B[r*c]
	/// c = 1. that is B is a column.
	/// 
	/// <see cref="nilnul.num.real.pred_.simult_.linear_.IEquality"/>
	/// 
	/// 
	/// 
	/// </summary>
	/// <remarks>
	///	in all
	///		, if b is in the subspace spanned by the cols of A, then there is a solution;
	///			0 is always in the space spanned by cols. so there is always a solution.
	///			when the cols are dependent, there are plural solutions. other wise, there is only one solution. 
	///		, otherwise, there is no solution.
	///
	/// 
	/// </remarks>
	/// alias:
	///		system of linear equations, regarding unknowns as scalars.
	///		linear equation, regarding unknown as a matrix, which is a col here.
	///
	[Obsolete(nameof(pred_.rudic_.col_.IEquation))]
	public interface IColumn:matrix.pred_.equat_.ILinear
    {
    }
}
