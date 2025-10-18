namespace nilnul.num.real.matrix.op_.rowspan_.gaussian_._stretch_.by_
{
	static public class _ElementaryMatrixX
	{
		static public Q[,] _Elementary_0wide_1row_2unnil(
			int wide
			,
			int row
			,
			Q _coef_unnil
		)
		{
			var r = new Q[wide, wide]; /// when this is 0*0, then it's returned.



			for (int i = 0; i < wide; i++)
			{
				int j = 0;
				for (; j < i; j++)
				{
					r[i, j] = 0;
				}

				r[i, j++] = (i==row? _coef_unnil: 1 );

				for (; j < wide; j++)
				{
					r[i, j] = 0;

				}

			}
			return r;

		}

	}
}
