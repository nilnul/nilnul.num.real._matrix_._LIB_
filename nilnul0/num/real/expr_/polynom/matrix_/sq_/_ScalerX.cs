using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom.matrix_.sq_
{
	/// <see cref="num.real.expr_.algebraic.matrix_.square_."/>
	/// <summary>
	/// 
	/// </summary>
	static public class _ScalerX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public real.expr_.Algebraic[,] Generate(int width, real.expr_.Algebraic scale) {

			var m = nilnul.num.real.expr_.polynom.matrix_.sq_._NilX.Generate(width);

			for (var i = 0; i<width; i++)
			{
				m[i, i] = scale;
			}

			return m;

		}
	}
}
