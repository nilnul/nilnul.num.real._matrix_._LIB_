using System;

namespace nilnul.num.real.matrix.rows_.unnil
{
	static public class _UnialX
	{
		static public void UnialRows(double[,] a) {
			int rows = a.GetLength(0);
			int cols = a.GetLength(1);

			for (int r = 0; r < rows; r++) {
				var p = 0d;

				for (int c = 0; c < cols; c++) {
					p+= nilnul.num.real.op_.Square.Singleton.op(a[ r,c]);
				}

				p=Math.Sqrt(p);

				for (int c0 = 0; c0 < cols; c0++) {
					a[ r, c0]/=p;
				}
				

			
			}
		}
	}


}
