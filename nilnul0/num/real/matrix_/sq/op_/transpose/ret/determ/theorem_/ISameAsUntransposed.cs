using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.op_.transpose.ret.determ.theorem_
{
	/// <summary>
	/// proof:
	///		if A is inversible, then 
	///			A = E1 E2 E3 ... En
	///				,where E[i] is basic square matrix.
	///		; observer basic matrix transposed  has the same determinant;
	///		
	/// proof:
	///		<see cref="matrix_.sq._determ_.by_.IByPermutation"/>, where each permutation as a biject is mapping from rowIndex to colIndex;
	///		transposed, the permutation would become the invert.
	///		the sign of the invert would not change, per <see cref="nilnul.sortie.permute.re_.invert.so_.ISameSign"/>.
	///	; and the permutations in <see cref="matrix_.sq"/>	 and <see cref="matrix_.sq.op_.transpose.ret"/> are biject.
	///		hence the sums are equal.
	///		
	/// </summary>
	internal class ISameAsUntransposed
	{
	}
}
