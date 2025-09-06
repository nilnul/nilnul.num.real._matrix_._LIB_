using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix
{
	static public class ExtensionsX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Eq(
			this Q[,] a, Q[,] b
		) {
			return Eq8quotient.Singleton.Equals(a, b);
		}
	}



}
