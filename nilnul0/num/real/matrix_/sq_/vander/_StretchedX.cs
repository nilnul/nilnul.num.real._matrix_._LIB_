using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.matrix_.sq_.vander
{
	/// <summary>
	/// eg:
	///		a0, a0 x, a0 xx,...
	///		a1, a1 x1, a1 x1 x1,...
	///		....
	///		a[n], a[n] x[n], a[n] x[n] x[n], ...
	/// </summary>

	static public class _StretchedX {

		static public Q[,] _ToMatrix_0bases_p1amplifiers(Q[] initials, params IEnumerable<Q> x)
		{

			int width = initials.Length;

			//int dimensionMinus = dimension - 1;

			var r = nilnul.obj.matrix_._SquareX._Init_0width<Q>(
				width
			);


			var enumerator = x.GetEnumerator();

			for (int row = 0; row < width; row++)
			{
				enumerator.MoveNext();
				var amper =enumerator.Current;

				Q cel = r[row, 0] = initials[row];

				for (int col = 1; col < width; col++)
				{
					r[row, col] = cel*= amper;
				}
			}
			return r;
		}

	}

}
