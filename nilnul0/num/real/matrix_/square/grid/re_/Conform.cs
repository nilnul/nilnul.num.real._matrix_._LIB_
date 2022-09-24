using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square.grid.re_
{
	/// <summary>
	/// left and right can have different partitions, 
	/// as long as, after partition, the left cols is equal to the right rows per the count of each col/row respectively.
	/// 
	/// eg:
	///		its possible to partition the first into rows, and the second into cols. here, the cols of the left grid is one; and the rows of the second grid is one also.
	/// 
	/// </summary>
	/// <remarks>
	/// if you want the same partition to work on both left and right, 
	/// <see cref="matrix.grid.re_._ConformX"/>; this effectively requires each dialog component, a submatrix|bloc, is square.
	/// </remarks>
	class Conform
	{
	}
}
