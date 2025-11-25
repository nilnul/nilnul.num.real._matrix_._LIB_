using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq
{
	/// <summary>
	/// the diagonal cels. 
	/// </summary>
	/// alias:
	///		diagonal:<see cref="sq_.IDiagonal"/>
	///
	static public class _RidgeX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<Q> _Ridge_0square(Q[,] matrix) {

			return nilnul.obj.matrix_.sq._DiagonalX._Diagonal_0sq(matrix);

			//int v = matrix.GetLength(0);

			//for (int i = 0; i < v; i++)
			//{
			//	yield return matrix[i, i];
			//}
		}
	}



}
