using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.diag.factorize_.streched_
{
	static public class _PortraitX
	{
		/// <summary>
		/// eg
		/// {
		///		1,0,0
		///		0,2,0
		///		0,0,3
		///		0,0,0
		/// }
		/// ,as:
		/// {
		///		1,0,0
		///		0,1,0
		///		0,0,1
		///		0,0,0
		/// }
		///		*
		///		{
		///			1,0,0
		///			0,2,0
		///			0,0,3
		///		}
		///	; colwise strech
		/// </summary>
		/// <returns>
		/// .stretch
		///		:<see cref="num.real.matrix_.ISquare"/>, the width of which is: 
		/// </returns>
		/// 

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q[,] std, Q[,] stretch) _StdStretched_2leRows(
			IEnumerable<Q> diag
			,
			int rows
			,
			int cols
		) {

			return (
				nilnul.num.real.matrix_.std_._PortraitX.OfRowsCols(rows, cols)
				,
				nilnul.num.real.matrix_.sq_._DiagonalX.OfDiagonal(diag)
			);
		}
	}
}
