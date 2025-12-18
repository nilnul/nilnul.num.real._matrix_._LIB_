using nilnul.num.quotient.str;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.sym.bi_.add.at_.unival9diag_.unnil8diag
{
	/// <summary>
	///  
	/// </summary>
	/// 

	static public class _DeterminantX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="claw">
		/// </param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q _Determ_0unival_1unnil8diag(Q unival, Q[] ridge ) {
			///<see cref="uniundiag._DeterminantX._Determinant_0wide_1ridge_2undiagVal(quotient_.DenomNonnil[], quotient_.DenomNonnil)"/>, 
			/// subtract row0 from every other row, and we get:
			/// 
			/// <see cref="paw_.unnil8torso5diag._DeterminantX"/>
			return (
				1+ unival * Enumerable.Range(0, ridge.Length).Select(
					i=>ridge[i].toInverse()
				).Sum()
			)*ridge.Aggregate(
				(Q)1, (a,c)=>a*c
			);
		}
	}
}
