using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.bi_
{
	/// <summary>
	/// </summary>
	static public class _SubtractX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a">
		/// :<see cref="matrix_.ISquare"/>
		/// </param>
		/// <param name="b"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Q[,] _Minus_0equilat_1scaler(this Q[,] a, Q b)
		{

			return num.real.matrix.bi_._SubtractX._Minus_1equisize(
				a, 
				real.matrix_.sq_.diag_._ScalerX.Generate_0width(a.GetLength(0), b)	
			);

		}

	}
}
