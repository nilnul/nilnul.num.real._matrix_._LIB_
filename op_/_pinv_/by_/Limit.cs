using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_._pinv_.by_
{
	/// <summary>
	///  p. 19 in Albert, A., Regression and the Moore-Penrose Pseudoinverse, Academic Press, New York, 1972.
	///  We refer to this as the “limit definition of the pseudoinverse.”
	///  lim as d->0:
	///		(A^T *A + d^2 I ) ^(-1) * A^T
	///  or
	///  lim as d->0:
	///		A^T (A A^T + d^2 I ) ^(-1)  
	/// 
	/// </summary>
	class Limit
    {
    }


}
