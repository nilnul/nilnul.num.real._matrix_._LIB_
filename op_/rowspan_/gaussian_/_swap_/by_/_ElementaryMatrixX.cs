namespace nilnul.num.real.matrix.op_.rowspan_.gaussian_._swap_.by_
{
	static public class _ElementaryMatrixX
	{
		static public Q[,] _Elementary_0wide_1row_2other(
			int wide
			,
			int row
			,int other
		)
		{
			var r = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(wide);

			r[row, row] = 0;
			r[other, other] = 0;

			r[row, other] = 1;
			r[other, row] = 1;

		
			return r;

		}

	}
}
