using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.basic_.skew.op_
{
	/// <summary>
	/// [
	///		1,0
	///		-k,1
	///	]
	///	, the <see cref="num.real.matrix_.sq.op_.cofactor"/>:
	///		[
	///			1, k
	///			0,1
	///		]
	///	, transposed:
	///		[
	///			1,0
	///			k,1
	///		]
	///	; add back those subtracted.
	/// </summary>
	/// <see cref="sq_.gauss.op_._InvertX"/>

	public interface IInverse
	{
	}
}
