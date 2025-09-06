using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.unary_
{
	/// <summary>
	/// Penrose Inverse;
	/// eg:
	///		for 0, the returned is 0;
	/// </summary>
	/// <remarks>
	/// The pseudoinverse is defined and unique for all matrices whose entries are real or complex numbers
	/// </remarks>
	/// alias:
	///		penrose inverse
	///		,generalized inverse
	///		pseudoinverse
	///		Moore-Penrose inverse;
	internal class Inverse
		: nilnul.num.real.matrix.op_.Unary4dblI
	{
		public double[,] op(double[,] x)
		{
			///
			/// according to Penrose theorem, for any A, there exists a unique B, such that:
			/// ABA=A, BAB=B, (AB)* = AB,  (BA)*  = BA
			/// , where * means conjugate transpose, or Hemitian transpose, which is transpose, and then replace each element with the element's conjugate; For real matrices, the conjugate transpose is just the transpose

			throw new NotImplementedException();
		}
	}
}
