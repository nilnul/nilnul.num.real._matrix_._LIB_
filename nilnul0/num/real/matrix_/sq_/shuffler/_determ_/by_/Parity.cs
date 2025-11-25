using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.shuffler._determ_.by_
{
	/// <summary>
	/// use the parity to determine the sign.
	/// </summary>
	static public class _ByParityX
	{
		static public Q _Determ_0shuffler(Q[,] matrix)
		{

			int h = matrix.GetLength(0);
			return nilnul.sortie.shuffle.be_.parity_._NegativeX._Negative_0shuffle(
				Enumerable.Range(
					0,
					h
				).Select(r =>
					nilnul.num.real.matrix.row._PivotX._Pivot_1wide_2row(in matrix, in h, in r)
				)
			) ? -1 : 1

				;

		}
	}
}
