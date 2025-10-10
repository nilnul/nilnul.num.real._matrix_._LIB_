using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.isohigh.bi_.jux
{
	static public class _CumulateX
	{
		static public Q[,] Juxtaposes(int high, IEnumerable<Q[,]> ms) {
			var cols = ms.Select(m => m.GetLength(1)).Sum();
			var r= new Q[high, cols];

			var colBase = 0;
			foreach (var m in ms) { 
				for (var i = 0; i < m.GetLength(1); i++,colBase++)
				{
					for (var j = 0; j<high; j++)
					{
						r[ colBase,j] = m[i, j];
					}

				}
			}
			return r;

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Juxtaposes_0started(IEnumerable<Q[,]> ms)
		{
			return Juxtaposes(ms.First().GetLength(0), ms);
		}

	}
}
