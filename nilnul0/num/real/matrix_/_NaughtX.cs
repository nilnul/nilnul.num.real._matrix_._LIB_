using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_
{
	/// <summary>
	/// when a matrix is initialized, it's already all nils.
	/// </summary>
	static  class _NaughtX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] Generate(int x,int y) {
			return new double[x, y];
		}

		static public Q[,] Generate8quotient(int x,int y) {
			var r= new Q[x, y];

			for (int i = 0; i < x; i++) {
				for (int j = 0; j < y; j++)
				{
					r[i, j] = 0;
				}
			}
			return r;
		}

	} 
}
