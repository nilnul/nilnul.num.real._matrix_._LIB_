using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.diag.factorize_
{
	static public class _StretchedX
	{
		/// <summary>
		/// </summary>
		/// <returns>
		/// .stretch
		///		:<see cref="num.real.matrix_.ISquare"/>, the width of which is: 
		/// </returns>
		/// 

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q[,],Q[,]) Stretch(
			IEnumerable<Q> diag
			,
			int rows
			,
			int cols
		) {
			return rows<=cols
				? streched_._LandscapeX._StretchedStd_2geRows(diag, rows, cols)
				: streched_._PortraitX._StdStretched_2leRows(diag, rows, cols);
		}
	}
}
