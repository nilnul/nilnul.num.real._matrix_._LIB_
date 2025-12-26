using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.matrix_.sq_.vander.stretched_
{
	/// <summary>
	/// for each progression, the initial term:1, is skipped.
	/// eg:
	///		x,  xx,...
	///		x1,  x1 x1,...
	///		....
	///		x[n], x[n] x[n], ...
	/// </summary>

	static public class _TorsoX {

		static public Q[,] _ToMatrix_p0amplifiers(params IEnumerable<Q> x)
		{

			int width = x.Count();

			//int dimensionMinus = dimension - 1;

			var r = nilnul.obj.matrix_._SquareX._Init_0width<Q>(
				width
			);


			var enumerator = x.GetEnumerator();

			for (int row = 0; row < width; row++)
			{
				enumerator.MoveNext();
				var amper =enumerator.Current;

				Q accumulated = r[row, 0] = amper;

				for (int col = 1; col < width; col++)
				{
					r[row, col] = accumulated*= amper;
				}
			}
			return r;
		}

	}

}
