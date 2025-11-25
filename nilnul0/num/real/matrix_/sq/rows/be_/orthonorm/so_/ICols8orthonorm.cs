using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.rows.be_.orthonorm.so_
{
	/// <summary>
	/// claim:
	///		if rows are orthonorm, then cols are orthonormal.
	///	proof:
	///		A.rows are orthonorm, then A A^T = I
	///		,
	///		then A^T A = I
	///		,
	///		then the first row of A^T is normal, as the sumOfProduct is 1, and it's orthic to other rows, as the sop is 0.
	///		analoguely, any other two rows are orthonorm.
	///		hence the cols are orthonorm.
	/// </summary>
	internal class ICols8orthonorm
	{
	}
}
