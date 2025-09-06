namespace nilnul.num.real.matrix.op_.rowspan_.gaussian_._slant_.by_
{
	static public class _ElementaryMatrixX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="wide"></param>
		/// <param name="row"></param>
		/// <param name="otherRow">
		/// after <paramref name="row"/>, like <see cref="_swap_.by_._ElementaryMatrixX._Elementary_0wide_1row_2other(int, int, int)"/>
		/// </param>
		/// <param name="_coef_unnil"></param>
		/// <returns></returns>
		static public Q[,] _Elementary_0wide_1row_2other(
			int wide
			,
			int row
			,
			int otherRow
			,
			Q _coef_unnil
		)
		{
			var r =nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(wide);

			r[row, otherRow] = _coef_unnil;

			return r;

		}

	}
}
