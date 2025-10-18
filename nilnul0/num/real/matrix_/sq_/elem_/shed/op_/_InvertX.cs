using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.elem_.shed.op_
{
	static public class _InvertX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_shed">
		///  the <see cref="sq_.elem_.IShed"/>
		/// </param>
		/// <param name="row">
		///  the row of the cel which is used to scale the row/col
		/// </param>
		/// <param name="col">
		/// the col of the cel which is used to scale the row/col
		/// </param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Invert_1row_2col(ref Q[,] _shed, int row, int col) {
			_shed[row, col] = 1/_shed[row, col];
		}
	}
}
