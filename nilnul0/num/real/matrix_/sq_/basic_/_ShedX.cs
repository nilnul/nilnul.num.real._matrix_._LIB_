namespace nilnul.num.real.matrix_.sq_.basic_
{
	/// <summary>
	/// </summary>
	/// alias:
	/// 
	static public class _ShedX
	{
		/// <summary>
		/// to make this <see cref="sq_.IElemental"/>, the scalar must be unnil.
		/// </summary>
		/// <param name="wide"></param>
		/// <param name="shaft">
		/// must be unnil
		///  if we want to divide one row by x, then here the arg is 1/x.
		///  Here in matrix, we need the multiplication, not division, as multiplication is associable;
		/// </param>
		/// <param name="row">
		/// 
		/// </param>
		/// <returns></returns>
		static public Q[,] _Shed_0positive_1row(int wide, int row, Q shaft) {
			var r = matrix_._SquareX.Init8quotient(wide);
			r[row, row] = shaft;

			return r;

		}
	}

}
