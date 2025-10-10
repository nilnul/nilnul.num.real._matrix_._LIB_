using System;

namespace nilnul.num.real.matrix.col_.unnil
{
	static public class _UnialX
	{
		/// <summary>
		/// assume the cols are unzero.
		/// </summary>
		/// <param name="a"></param>
		static public void _Unial_1colUnnil(ref double[,] a, int c)
		{
			int rows = a.GetLength(0);

			var p = 0d;

			for (int r = 0; r < rows; r++)
			{
				p+= nilnul.num.real.op_.Square.Singleton.op(a[r, c]);
			}

			p=Math.Sqrt(p);

			for (int r1 = 0; r1 < rows; r1++)
			{
				a[r1, c]/=p;
			}



		}
	}


}
