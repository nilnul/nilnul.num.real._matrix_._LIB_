using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.eq
{
	static public class _VowX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void Vow(Q4[,] a, Q4[,] b) {
			if (! real.matrix.Eq8quotient.Singleton.Equals(a,b) )
			{
				throw  nilnul.obj.be._vow.NotAsException.Of(
					typeof(matrix.Eq8quotient)
					,(a,b)
				);
			}
		}
	}
}
