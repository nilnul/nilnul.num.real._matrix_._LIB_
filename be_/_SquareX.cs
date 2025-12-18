using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	/// equilateral
	/// </summary>

	static public class _SquareX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(in Q[,] m)
		{
			return m.GetLength(0) == m.GetLength(1);
		}


	}


}
