using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.factorize_.similar_.xpn_
{
	/// <see cref="sq.be_.ITriagible"/>
	/// <summary>
	/// A real matrix is not always similar (over ℝ) to an upper triangular matrix.
	/// 
	/// </summary>
	/// <remarks>
	/// if a real matrix has complex eigenvalues, it cannot be similar (over ℝ) to any real triangular matrix — because triangular matrices have only real entries on the diagonal, which would contradict the complex eigenvalues.
	///
	///  	 but it can be similar to complex triag:<see cref="num.complex.matrix_.sq.to_.factorize_.similar_"/>
	///
	/// </remarks>
	public interface ITriagonal
	{
	}

}
