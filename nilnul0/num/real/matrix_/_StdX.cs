using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	/// 
	static public  class _StdX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="rows"></param>
		/// <param name="cols"></param>
		/// <param name="rank">
		/// will be no more than either rows or cols
		/// </param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _OfRowsCols_2rank(
			int rows
			,
			int cols
			,
			int rank
		) {
			return rows<=cols ? std_._LandscapeX._OfRowsCols_2rank(rows, cols,rank) : std_._PortraitX._OfRowsCols_2rank(rows, cols, rank);
		}
	}
}
