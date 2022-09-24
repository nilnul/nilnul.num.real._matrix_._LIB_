using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.re_
{
	/// <summary>
	/// A is equiv to B
	///		if we can find invertibles: Q, and P such that
	///			B = PA/Q
	/// Two matrices are equivalent if and only if they have the same rank.
	/// </summary>
	/// The notion of equivalence should not be confused with that of similarity:<see cref="matrix_.square.re_.ISimilar"/>, which is only defined for square matrices, and is much more restrictive(similar matrices are certainly equivalent, but equivalent square matrices need not be similar)
	/// en.wikipedia.org/wiki/Matrix_equivalence
	/// 
	public interface IEquiv
	{

	}
	///   cannonic augmented by nils.
}
