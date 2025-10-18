using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_
{
	/// <summary>
	/// either rowly independent or columnly independent.
	/// by default this means rows, not cols. for cols, <see cref="real.matrix.cols.be_"/>
	/// </summary>
	/// alias:
	///		<see cref="real.matrix.be_.IBasis"/>
	public interface IIndependent:real.IMatrix
    {
    }

}
