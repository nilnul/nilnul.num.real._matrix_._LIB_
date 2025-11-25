using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.cel
{
	/// <summary>
	/// remove the row and col. the remained submatrix
	/// the first major submatrix. 
	/// </summary>
	static public class _RemnantX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="i"> nonneg, lt width</param>
		/// <param name="j">nonneg, lt height</param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Remnant_assumeValid(double [,] matrix, int i, int j) {
			return nilnul.obj.matrix.cel._RemnantX._Remnant_celAssumeValid(matrix, i, j);

		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] _Remnant_1row_2col(Q4 [,] matrix, int i, int j) {
			return nilnul.obj.matrix.cel._RemnantX._Remnant_celAssumeValid(matrix, i, j);

		}

	}
}
