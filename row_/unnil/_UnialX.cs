using System;

namespace nilnul.num.real.matrix.row_.unnil
{
	static public class _UnialX
	{
		/// <summary>
		/// assume the cols are unzero.
		/// </summary>
		/// <param name="a"></param>
		static public void _Unial_1rowUnnil(ref double[,] a, int row)
		{
			int wide = a.GetLength(1);

			var p = 0d;

			for (int w = 0; w < wide; w++)
			{
				p+= nilnul.num.real.op_.Square.Singleton.op(a[ row,w]);
			}

			p=Math.Sqrt(p);

			for (int w = 0; w < wide; w++)
			{
				a[ row,w]/=p;
			}



		}
	}


}
