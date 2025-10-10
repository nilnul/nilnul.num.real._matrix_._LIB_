using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.isowide.bi_.subside
{
	static public class _CumulateX
	{
		static public Q[,] Subsides(int wide, IEnumerable<Q[,]> ms) {
			var rows = ms.Select(m => m.GetLength(0)).Sum();
			var o= new Q[rows, wide];

			var r = 0;
			foreach (var m in ms) { 
				for (var i = 0; i < m.GetLength(0); i++,r++)
				{
					for (var j = 0; j<wide; j++)
					{
						o[ j,r] = m[i, j];
					}

				}
			}
			return o;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Subsides_0started( IEnumerable<Q[,]> ms) {
			return Subsides(ms.First().GetLength(1), ms);
		}


	}
}
