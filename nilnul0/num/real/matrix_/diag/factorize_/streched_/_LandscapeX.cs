using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.diag.factorize_.streched_
{
	static public class _LandscapeX
	{
		/// <summary>
		/// eg
		/// {
		///		1,0,0,0
		///		0,2,0,0
		///		0,0,3,0
		/// }
		/// ,as:
		///		{
		///			1,0,0
		///			0,2,0
		///			0,0,3
		///		}
		///		*
		///		{
		///			1,0,0,0
		///			0,1,0,0
		///			0,0,1,0
		///		}
		///	; rowwise stretch
		/// </summary>
		/// <returns>
		/// </returns>
		/// 

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q[,] stretch, Q[,] std) _StretchedStd_2geRows(
			IEnumerable<Q> diag
			,
			int rows
			,
			int cols
		) {

			return (
				nilnul.num.real.matrix_.sq_._DiagonalX.OfDiagonal(diag)
				,
				nilnul.num.real.matrix_.std_._LandscapeX.OfRowsCols(rows, cols)
			);
		}
	}
}
