using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.decom_.row.every.determ
{
	/// <summary>
	/// d(A) = d(B) + d(C)
	///		,when A is <see cref="decom_.IOneRow"/>ed as B,C
	/// </summary>
	/// <remarks>
	///  note:<see cref="num.real.matrix_.isosize.bi_.celwise_._AddX"/> decomposed into:
	///		2^n matrix. not 2n matrix. So we cannot simply sum the determ of that two matrices;
	/// </remarks>
	public interface ISum
	{
	}
}
