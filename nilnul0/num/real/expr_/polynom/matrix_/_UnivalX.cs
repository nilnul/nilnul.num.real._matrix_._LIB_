using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom.matrix_
{
	static public class _UnivalX
	{
		static public Algebraic[,] Generate(int height, int width, Algebraic v ) {
			var m = new Algebraic[height,width];
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					m[i, j] = v;
				}
			}
			return m;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Algebraic[,] Generate(int height, int width) {
			
			return Generate(height,width,0);
		}

	}
}
