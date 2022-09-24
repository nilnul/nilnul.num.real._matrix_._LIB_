using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.of_
{
	static public class _RandomX
	{
		static public double[,] _Dbl_rowsColsAssumeNonnegs(int _rowsNonneg, int _colsNonneg) {

			var r = new System.Random();
			var m = new double[_rowsNonneg,_colsNonneg];
			for (int i = 0; i < _rowsNonneg; i++)
			{
				for (int j = 0; j < _colsNonneg; j++)
				{
					m[i,j] = r.NextDouble();
				}

			}
			return m;
		}
	}
}
