using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom.matrix_.unival_
{
	static public class _OnesX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Algebraic[,] Generate(int height,int width ) {
			
			return matrix_._UnivalX.Generate(height, width,1);
		}


	}
}
