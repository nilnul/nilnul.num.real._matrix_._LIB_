using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.co_.multible.prod
{

	static public class _TransposedX
	{
		/// <summary>
		/// (ab)^T = b^T a^T
		///		,just like back walking an elbow
		/// ,
		///  for sizes:
		///		left hand side: (m*n, n*p  )^T = (m*p)^T = p*m
		///		right hand side: (p*n, n*m) = p*m
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _TransposeProduct_1chainable(Q[,] a, Q[,] b) {
			return num.real.matrix.co_.multible._MultiX._Multiply_1sociable(a, b).Transpose();
		}
	}
}
