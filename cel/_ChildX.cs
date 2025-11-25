using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.cel
{
	/// <summary>
	///  
	/// </summary>
	/// <see cref="_RemnantX"/>
	static public class _ChildX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Child_assumeValid(double [,] matrix, int i, int j) {
			return nilnul.obj.matrix.cel._ChildX._Child_celAssumeValid(matrix, i, j);

		}
	}
}
