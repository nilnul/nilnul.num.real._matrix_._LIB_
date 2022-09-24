using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.co_.multible.multi_.byGrid_
{
	/// <summary>
	/// slice the structure/template of the vec uniformly.
	/// take out each component,and disregard the others, we would get the result of the original structure with each cel being subtracted somewhat. If we add such results together we will get the full result.
	/// 
	/// </summary>
	/// alias:
	///		compart
	///			component part
	///		slice
	///	vs: <see cref="IByGrid"/>, which splices the matrix as a str, one that is of vecs
	public interface IByCompart:IByGrid
	{

	}
}
