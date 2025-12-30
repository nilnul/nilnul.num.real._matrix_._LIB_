using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix
{
	static public class _EqX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Eq(in Q4[,] a, in Q4[,] b) {
			return num.quotient.matrix.Eq.Singleton.Equals(a, b);
		}
	}

}