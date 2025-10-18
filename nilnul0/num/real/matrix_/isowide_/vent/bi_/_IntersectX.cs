using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.isowide_.vent.bi_
{
	static public class _IntersectX
	{
		static public IEnumerable<int> Intersect(
			Q[,] a
			,
			Q[,] b
		)
		{

			var bH = b.GetLength(0);

			if (bH ==0)
			{
				yield break;
			}

			int bR = 0;
			int bH_minus = bH -1;
			var bP = nilnul.num.real.matrix.row._PivotX.Pivot(ref b, 0);

			var w = a.GetLength(1);

			int aH = a.GetLength(0);

			for (int i = 0; i < aH; i++)
			{
				/// find aRows that is also in b:
				/// 

				var aP = nilnul.num.real.matrix.row._PivotX.Pivot(ref a, i);

				while (bP>aP) {
					if (bR == bH_minus) {
						yield break;
					}
					bP = nilnul.num.real.matrix.row._PivotX.Pivot(ref b, ++bR);
				}

				if (bP == aP) {
					/// compare the two rows
					/// the pivot is already 1;
					for (int vC = bP+1; vC < w; vC++)
					{
						if (a[i, vC] != b[bR, vC]) {
							break;
						}
					}
					yield return i;
				}
				/// bP lt aP



			}

		}
	}
}
