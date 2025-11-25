namespace nilnul.num.real.matrix.op_.rowspan_.gaussian_._stretch_.by_
{
	static public class _ElementaryMatrixX
	{
		/// <summary>
		/// 0*0 has no such matrix.
		/// </summary>
		/// <param name="wide"></param>
		/// <param name="row"></param>
		/// <param name="_coef_unnil"></param>
		/// <returns></returns>
		static public Q[,] _Elementary_0wide_1row_2unnil(
			int wide
			,
			int row
			,
			Q _coef_unnil
		)
		{
			var r = num.real.matrix_.sq_._CanonicalX.Generate8quotient(wide); /// when this is 0*0, then it's returned.
			r[row, row] = _coef_unnil;

			return r;
		}

	}
}
