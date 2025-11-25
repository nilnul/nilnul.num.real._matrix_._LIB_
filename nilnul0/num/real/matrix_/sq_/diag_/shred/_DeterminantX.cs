using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.diag_.shred
{
	static public class _DeterminantX
	{
		/// <summary>
		/// this algorithm also works when the shedder is 0;
		/// </summary>
		/// <param name="_shed">
		///  the <see cref="sq_.basic_.IShed"/>
		/// </param>
		/// <param name="row">
		///  the row of the cel which is used to scale the row/col
		/// the col of the cel which is used to scale the row/col
		/// </param>
		/// alias:
		///		determ, verbize the noun:determinant
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _Determ_1index(in Q[,] _shed, int row) {
			return _shed[row, row];
		}
	}
}
