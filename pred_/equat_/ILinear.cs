using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.pred_.equat_
{
	/// <summary>
	/// AX = B, where B is a matrix [r * c], A is a matrix [r* t], X is matrix [t * c] which is yet unknown.
	///
	/// or AX - B =0;
	/// 
	/// </summary>
	/// note: r*c is used to describe B.
	/// <remarks>
	///
	/// </remarks>
	/// note: B can be multicolumned;
	///
	/// alias:
	///		pseudolinear
	///
	[Obsolete(nameof(pred_.linear_.IEquatation))]
	public interface ILinear :matrix.pred_.IEquatation
    {
    }
}
