using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient
{
	/// <summary>
	/// for <see cref="num.real.matrix.expr_.IPolynomial"/>, quotient matrix results as quotient matrix.
	/// So as long as we don't apply eigen (which involves radicand,hence irrational), quotient matrix is what we need,and it keeps things simple and clear. So maybe the basic matrix operation shall be defined on quotient matrix. and later, for eigen value, we can study that in complex matrix (as eigen solvent is in general complex, beyond real)
	/// ;
	/// this would make it patent that we study only polynomial expressions first, and eigen would be deferred to another alter proj: complex.matrix;
	/// </summary>
	/// <remarks>
	///  <see cref="nilnul.algebra.IModule"/> the field/ring can be quotient, or event integer.
	/// </remarks>
	/// <example></example>
	public interface IMatrix:nilnul.obj.IMatrix<num.IQuotient>
	{
	}
}
