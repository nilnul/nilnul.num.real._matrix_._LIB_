using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.co_
{
	/// <summary>
	/// A/B = A*B^-1, where B:
	///		1) must be invertible square. <see cref="matrix_.square_.IInvertible"/>
	///		2) cols count is the same as rows of A
	///	to write A*B^-1 as A/B, we make it shorter, and easy to keyIn, and also less confusing without the "^", which is ambinguous and also brings about problem of operator precedence.
	/// </summary>
	public interface IDivisible
	{
	}
}
