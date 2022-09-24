using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.invertible.op_.unary_.transpose_
{
	/// <summary>
	/// same result as <see cref="invert_.ITranspose"/>
	/// as A^T * (A^-1)^T = (A*A^-1)^T = C
	/// also true for:  (A^-1)^T * A^T  = (A*A^-1)^T = C
	/// So A^T is the inverse of (A^-1)^T; so (A^T) ^-1 = A^(-1) ^T
	/// </summary>
	class IInverse
	{
	}
}
