using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.grid_.diag_
{
	/// <summary>
	/// eg:
	///		[
	///			I,0
	///			0,0
	///		]
	///	,where I is <see cref="real.matrix_.sq_.ICanonic"/>. the 0 on the diagonal can be unequalat.
	///	eg:
	///		[ 
	///			1,0,0
	///			 0,0,0
	///		]
	/// </summary>
	public interface IStd:matrix.grid_.IDiagonal
	{
	}
}
