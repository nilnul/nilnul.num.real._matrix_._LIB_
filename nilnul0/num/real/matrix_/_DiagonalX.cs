using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_
{
	public class _DiagonalX 
    {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="rows"></param>
		/// <param name="cols"></param>
		/// <param name="values">0s are padded when necessary</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] Diagonal(
			int rows, int cols,
			IEnumerable<double> values
		) {
			return rows <= cols ? diag_._LandscapeX.OfRowsCols(rows, cols, values) : diag_._PortraitX.OfRowsCols(rows,cols, values);
		}
	}

}
