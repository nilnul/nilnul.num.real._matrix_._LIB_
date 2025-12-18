using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom.matrix_.sq_
{
	static public class _UnivalX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Algebraic[,] Generate(int height, Algebraic v ) {
			
			return matrix_._UnivalX.Generate(height,height,v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Algebraic[,] Generate(int height) {
			
			return Generate(height,0);
		}

	}
}
