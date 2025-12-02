using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_.dent_._vent
{
	/// <summary>
	/// the leading is 1; but the column of the leading 1 might be not axial.
	/// eg:
	///		{
	///			1,1,1,0,1;
	///			0,0,1,1,0;
	///			0,0,0,0,0;
	///		}
	/// </summary>
	/// alias:
	///		echelon
	///		pivoted
	///		paragon
	///	vs:
	///		indep
	public interface IParagoned:IIndent
	{
	}


}
