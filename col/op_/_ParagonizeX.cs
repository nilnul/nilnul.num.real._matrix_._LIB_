using System;

namespace nilnul.num.real.matrix.col.op_
{
	static public class _ParagonizeX
	{
		/// <summary>
		/// </summary>
		/// <param name="a"></param>
		static public void Unial0nil(ref double[,] a, int c)
		{
			int rows = a.GetLength(0);

			var p = 0d;
			int r = 0;
			for (; r < rows; r++)
			{
				p+= nilnul.num.real.op_.Square.Singleton.op(a[r, c]);
			}
			if (p==0)
			{
				return;
			}
			p=Math.Sqrt(p);

			r = 0;
			for (; r < rows; r++)
			{
				a[r, c]/=p;
			}



		}
	}


}
