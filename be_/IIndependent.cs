using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	/// <see cref="real.matrix.rows.be_.IIndependent"/>:<see cref="real.matrix.be_.rowly_.IIndependent"/>
	/// or <see cref="real.matrix.cols.be_.IIndependent"/>: <see cref="real.matrix.be_.colly_.IIndependent"/>
	/// </summary>
	/// <remarks>
	/// <see cref="matrix.be_.rowly_.IIndependent"/> != <see cref="matrix.be_.colly_.IIndependent"/>
	/// ; even the rank is the same, col0rowEs might be redundant over the rank
	/// </remarks>
	/// alias:
	///		independence, same initial as <see cref="IInvertible"/>
	///		<see cref="real.matrix.cols.be_.IIndependent"/>
	///		<see cref="real.matrix_.dent.be_._IndependentX"/>
	///	
    public interface IIndependent
    {
    }



}
