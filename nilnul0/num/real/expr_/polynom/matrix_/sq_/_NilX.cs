using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom.matrix_.sq_
{
	static public class _NilX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public real.expr_.Algebraic[,] Generate(int width) {

			return nilnul.obj.matrix_.sq_._FlatX.Generate(width, Algebraic.Nil);
		}
	}
}
