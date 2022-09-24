using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee.matrix.duo
{
	public class InnerProduct

	{
		public double[,] _eval(double[,] a, double[,] b) {

			return new nilnul.matrix.duo_.associable.InnerProduct<double>(
				(x, y) => x * y
				, 
				(IEnumerable<double> str) => ieee.str.SumX.Sum(str)
			)._eval(a,b);

		}

	}
}
