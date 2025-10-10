using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix
{
	/// <summary>
	/// matrix shall be regarded as rows, not cols. Cols can be regarded as rows of a transposed matrix.
	/// convert <see cref="IMatrix"/> to a str of vec colwisely -- each col is a vec;
	/// 
	/// </summary>
	/// <remarks>
	///  <see cref="matrix.op_.Transpose"/> of the matrix, and get the <see cref="real.matrix.IRows"/>;
	///  
	///  note we can also swap the <see cref="real.matrix.bi_._MultiX"/> as:
	///		(XA)^T = A^T X^T 
	///		XA = (A^T X^T )^T
	///	; AB, and BA are in different superspace.
	/// </remarks>
	/// 

	public interface ICols
		:
		num.real.vec.IStr
	{
	}

}
