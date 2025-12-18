using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	/// unsquare
	/// </summary>

	static public class _ScaleneX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(in Q[,] m)
		{
			return m.GetLength(0)!= m.GetLength(1);
		}


	}


}
