namespace nilnul.num.real.matrix_.sq_.elem_.dwelt_._shed
{
	/// <summary>
	/// <see cref="real.matrix.op_._indent.gauss_.IShed"/>
	/// </summary>
	static public class _AmplifyOneRowX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="wide"></param>
		/// <param name="row">
		///  lt <paramref name="wide"/>
		/// </param>
		/// <param name="scalar">
		/// nilable
		/// </param>
		/// <returns></returns>
		static public Q[,] _AmpleOneRow_0wide_1row(
			int wide
			,
			int row
			,
			Q scalar

		)
		{
			var r = new Q[wide, wide];
			var i = 0;
			var j = 0;

			for (; i < row; i++)
			{
				j = 0;
				while (j<i)
				{
					r[i, j++] =0;
				}

				r[i, j++] =1;
				while (j<wide)
				{
					r[i, j++] =0;

				}
			}

			j = 0;
			while (j<i)
			{
				r[i, j++] =0;
			}
			r[i, j++] =scalar;
			while (j<wide)
			{
				r[i, j++] =0;
			}

			i++;

			for (; i < wide; i++)
			{
				j=0;
				while (j<i)
				{
					r[i, j++] =0;
				}

				r[i, j++] =1;
				while (j<wide)
				{
					r[i, j++] =0;

				}
			}
			return r;


		}
	}
}
