using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.vent_
{
	/// <summary>
	/// eg:
	///		[
	///			1,2,0
	///			0,0,1
	///			0,0,0
	///		]
	/// </summary>
	/// <see cref="num.real.matrix_.sq_.diag_.boolish_.IDegenerate"/>
	public interface IDegenerate
		:sq_.IVent
		,
		sq_.IDegenerate
	{
	}
}
