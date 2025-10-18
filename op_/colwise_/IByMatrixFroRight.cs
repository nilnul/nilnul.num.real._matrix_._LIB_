using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.colwise_
{
	/// <summary>
	/// with A, construct an <see cref="matrix.IOp"/> such for input X
	///		XA
	///	; which will change the cols of X.	
	/// </summary>
	public interface IByMatrixFroRight
		:op_._colwise_.by_.IMatrixMultiFroRight
	{
	}
}
