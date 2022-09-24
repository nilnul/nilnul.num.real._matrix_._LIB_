using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.canon.canon.elementary_.switches_
{
	static public class _ReversalX
	{
		static public double[,] _Generate_assumeNonneg(int size) {
			var r = new double[size, size];

			for (int row = 0; row < size; row++)
			{
				for (int col = size-1; col >=0; col--)
				{
					r[row, col] = 1;
				}
			}
			return r;
		}

	}

}
