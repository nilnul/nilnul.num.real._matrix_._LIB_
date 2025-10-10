using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.determinant_
{
	/// <summary>
	/// noticing that some small submatrix might be recalculated in large submatrix, we compute the determinant from bottom in anticipation it might be reused in upper larger scaled calculations;
	/// eg:
	///		1,2,3,4
	///		5,6,7,8
	///		9,10,11,12
	///		13,14,15,16
	///		we get:
	///			13,14,15,16
	///		we then get:
	///			9,10
	///			13,14
	///				which will be multiplid by both 7, and 8, later.
	///			
	///			9,11
	///			13,15
	///
	///			9,12
	///			13,16
	///
	///			10,11
	///			14,15
	///
	///			10,12
	///			14,16
	///
	///			11,12
	///			15,16
	///
	///		we then get:
	///			
	/// </summary>
	/// alias:
	///		byReuse
	///		byBottomUp
	internal class IByReuse
	{
	}
}
