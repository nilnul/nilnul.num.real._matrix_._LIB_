using System.Runtime.CompilerServices;
using T = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.polynom.matrix_.sq.be_
{
		/// <summary>
		/// if A = A**2
		/// </summary>
		/// <remarks>
		/// <see cref="real.matrix_.sq_.IProjectile"/>:P
		///		PPx = px
		///		,that is the vector is already in the screen shall be unchanged.
		/// </remarks>
	static public class _IdempotentX {

		/// <summary>
		/// if A = A**2
		/// </summary>
		/// <param name="sq"></param>
		/// <returns></returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Be_0sq(T[,] sq) {

			return num.real.expr_.polynom.matrix._EqX.Eq(
				num.real.expr_.polynom.matrix_.sq.op_._Pow2ndX._Square_0equilat(sq)
				,
				sq
			);

		}



	}



}
