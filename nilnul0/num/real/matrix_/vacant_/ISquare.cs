using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.vacant_
{
	/// <summary>
	/// 0*0.
	/// </summary>
	/// <remarks>
	/// represented by:
	///		[], which might be confused as empty str;
	///		
	///		r[0,0], which without prefix "r" would be [0,0], ambiguous to mean a str of two 0s.
	///
	/// </remarks>
	/// alias:
	///		nilNil
	///		empty:<see cref="matrix_.IVanity"/>
    public interface ISquare:INoCols,INoRows
    {
    }
}
