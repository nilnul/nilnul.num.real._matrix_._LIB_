using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.basic_.shed_
{
	/// <summary>
	/// make the pivot the divisor, such that this row would be one leading (standard).
	/// if the row is 0, xpn is thrown, per jure.
	/// </summary>
	public interface IPivot:op_.IShrink
	{
	}
}
