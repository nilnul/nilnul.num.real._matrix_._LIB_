using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.std_
{
	/// <summary>
	/// <see cref="real.matrix_.IPortrait"/>
	/// </summary>
	/// alias:
	///		dedundant
	static public  class _IndependentX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfRowsCols(
			int rows
			,
			int cols
		) {
			return rows<=cols ? std_.indep_._LandscapeX.OfRowsCols(rows, cols) : std_.indep_._PortraitX.OfRowsCols(rows, cols);
		}
	}
}
