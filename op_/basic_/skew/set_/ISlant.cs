using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.basic_.skew.set_
{
	/// <summary>
	/// <see cref="real.matrix_.sq_.basic_.skews_.ISlant"/>
	/// ,where each skew is on the same row.
	/// 
	/// eg:
	///		r[i] += Sigma(j,  k[j] r[j] ), where j!=i, and k[j] can be 0
	/// </summary>
	/// alias:
	///		slant
	///		slope
	///	<see cref="op_.colwise_.basic_."/>
	///	vs:
	///		<see cref="basic_.ISkews"/> which is a basic, whileas this is an extension and it can be not a subtype of <see cref="IBasic"/>
	public interface ISlant
		///:op_.basics_.
	{
	}
}
