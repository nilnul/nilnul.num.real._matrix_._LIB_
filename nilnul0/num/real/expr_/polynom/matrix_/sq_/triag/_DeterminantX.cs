using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.polynom.matrix_.sq_.triag
{

	/// <summary>
	/// </summary>
	static public class _DeterminantX
	{
		/// <summary>
		/// all upper cels are 0;
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		/// <see cref="real.matrix_.sq_.triag._DeterminantX"/>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public expr_.Algebraic _Determinant_0sq(A[,] m) {

			return sq._RidgeX._Ridge_0sq(m).Aggregate(
				Algebraic.One
				,
				(a,c) => a* c

			);

		}


	}
}
