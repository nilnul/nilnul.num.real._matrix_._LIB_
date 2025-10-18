using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.elem_.skew.op_
{
	static public class _InvertX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_skew">
		///  the <see cref="sq_.elem_.ISkew"/>
		/// </param>
		/// <param name="row">
		///  the row of the cel which is used to scale the other row/col
		/// </param>
		/// <param name="col">
		/// the col of the cel which is used to scale the other row/col
		/// </param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Invert_1row_2col(ref Q[,] _skew, int row, int col) {
			_skew[row, col] = -_skew[row, col];
		}
	}
}
