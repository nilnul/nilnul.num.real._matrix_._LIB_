using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.orthonorm.op_
{
	/// <summary>
	/// just transpose it, and we get its inverse;
	/// </summary>
	/// <remarks>
	/// A^T = A^-1, if A is orthonorm.
	/// thus,
	///		given a row X,
	///		
	///		A  X^T = (A^T)^T   X^T =   (A^-1)^T   X^T = ( XA^-1 )^T 
	///
	///		if X, the new row, is YA, where Y is an old row, then:
	///		A(X^T) = A (YA)^T = A  A^T Y^T = Y^T 
	///		
	///		that is A X^T = Y^T, while (YA) = X
	///	; So A can morph back and forth the old and new coordinates.
	///
	/// 
	/// </remarks>
	internal class Invert
	{
	}
}
