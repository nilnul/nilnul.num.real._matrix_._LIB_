using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.basic_.shed.op_
{
	static public class _InvertX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_shed">
		///  the <see cref="sq_.basic_.IShed"/>
		/// </param>
		/// <param name="row">
		///  the row of the cel which is used to scale the row/col
		/// the col of the cel which is used to scale the row/col
		///  
		/// </param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Invert_1index(ref Q[,] _shed, int row) {
			_shed[row, row] = 1/_shed[row, row];
		}
	}
}
