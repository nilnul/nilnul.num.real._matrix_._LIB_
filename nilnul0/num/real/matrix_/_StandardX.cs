using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_
{
	/// <summary>
	/// <see cref="real.matrix_.IPortrait"/>
	/// </summary>
	static public  class _StandardX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfRowsCols(
			int rows
			,
			int cols
		) {
			return rows<=cols ? std_._LandscapeX.OfRowsCols(rows, cols) : std_._PortraitX.OfRowsCols(rows, cols);
		}
	}
}
