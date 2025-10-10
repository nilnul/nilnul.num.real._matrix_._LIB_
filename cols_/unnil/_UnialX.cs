using System;

namespace nilnul.num.real.matrix.cols_.unnil
{
	static public class _UnialX
	{
		/// <summary>
		/// assume the cols are unzero.
		/// </summary>
		/// <param name="a"></param>
		static public void UnialCols(double[,] a) {
			int rows = a.GetLength(0);
			int cols = a.GetLength(1);

			for (int c = 0; c < cols; c++) {
				var p = 0d;

				for (int r = 0; r < rows; r++) {
					p+= nilnul.num.real.op_.Square.Singleton.op(a[ r,c]);
				}

				p=Math.Sqrt(p);

				for (int r1 = 0; r1 < rows; r1++) {
					a[r1, c]/=p;
				}
				

			
			}
		}
	}


}
