using System;

namespace nilnul.num.real.matrix.row.op_
{
	static public class _Unial0nilX
	{
		/// <summary>
		/// </summary>
		/// <param name="a"></param>
		static public void Unial0nil(ref double[,] a, int row)
		{
			int wide = a.GetLength(1);

			var p = 0d;
			int w = 0;
			for (; w < wide; w++)
			{
				p+= nilnul.num.real.op_.Square.Singleton.op(a[row, w]);
			}

			if (p==0)
			{
				return;
			}
			p=Math.Sqrt(p);

			w = 0;
			for (; w < wide; w++)
			{
				a[row, w]/=p;
			}



		}
	}


}
