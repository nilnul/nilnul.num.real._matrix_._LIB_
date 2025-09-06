using System.Collections.Generic;

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
		static public IEnumerable<Q> _Ridge_0square(Q[,] matrix) {
			int v = matrix.GetLength(0);

			for (int i = 0; i < v; i++)
			{
				yield return matrix[i, i];
			}
		}
	}



}
