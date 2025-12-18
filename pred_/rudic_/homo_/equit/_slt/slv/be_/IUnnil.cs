using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.pred_.rudic_.homo_.equit._slt.slv.be_
{
	/// <summary>
	/// one solvent is not 0.
	/// </summary>
	/// <remarks>
	/// as this is <see cref="IHomogeneous"/>, there is always a 0 solvent.
	/// To have a unnil slv, the rank of the matrix must be incomplete.
	/// if the <see cref="_rudic.ICoef"/> is <see cref="num.real.matrix.be_._DegenerateX"/>, then there is unnil solvent.
	/// </remarks>
	public interface IUnnil
	{
	}
}
