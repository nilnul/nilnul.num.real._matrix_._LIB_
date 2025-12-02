using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.real.expr_.algebraic.Frac;

namespace nilnul.num.real.expr_.rithmet.matrix_.sq
{

	/// <summary>
	/// </summary>
	/// <see cref="nilnul.obj.matrix.IRidge"/>
	static public class _RidgeX
	{
		/// <summary>
		/// all upper cels are 0;
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		/// <see cref="real.matrix_.sq_.triag._DeterminantX"/>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<A> _Ridge_0sq(A[,] m) {

			return Enumerable.Range(0,m.GetLength(0)).Select(i=> m[i,i]);

		}


	}
}
