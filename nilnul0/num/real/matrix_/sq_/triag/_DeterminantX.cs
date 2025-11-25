using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.triag
{
	static public class _DeterminantX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q _Determinant_0triag(Q[,] m) {
			return real.matrix_.sq._RidgeX._Ridge_0square(m).Aggregate(
				Q.One, (a, c) => a*c
			);
		}

	}
}
