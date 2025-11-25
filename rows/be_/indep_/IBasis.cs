using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.rows.be_.indep_
{
	/// <summary>
	/// span the whole space. 
	/// in other words, we have n rows that are <see cref="IIndependent"/>
	/// ;eg:
	///		in 0d, we have 0 such bases.
	/// </summary>
	/// alias:
	///		span,like space
	public interface IBasis
		:real.matrix.rows.be_.IIndependent
	{
	}

}
