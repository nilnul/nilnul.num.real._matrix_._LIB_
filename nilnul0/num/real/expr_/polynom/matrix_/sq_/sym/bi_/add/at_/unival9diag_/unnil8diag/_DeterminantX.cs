using nilnul.num.quotient.str;
using System.Linq;
using System.Runtime.CompilerServices;
using T = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.polynom.matrix_.sq_.sym.bi_.add.at_.unival9diag_.unnil8diag
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
		static public algebraic.Frac _Determ_0unival_1unnil8diag(T unival, T[] ridge ) {
			///<see cref="uniundiag._DeterminantX._Determinant_0wide_1ridge_2undiagVal(quotient_.DenomNonnil[], quotient_.DenomNonnil)"/>, 
			/// subtract row0 from every other row, and we get:<see cref="paw_.unnil8torso5diag._DeterminantX"/>
			return (
				1+ unival *
				num.real.expr_.algebraic.frac.op_.binary_.add.cumulator.Cumulate.Singleton.cumulate(  Enumerable.Range(0, ridge.Length).Select(
					i=> num.real.expr_.algebraic.Frac.Inverse( ridge[i])
				))
			)
			*
			num.real.expr_.polynom.bi_.mul.cumula.Cumulate.Singleton.cumulate(
				ridge
			);
		}
	}
}
