using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.doubleElement.squareMatrix.op
{
	public partial class Square
	{
		public static double[,] Eval(double[,] x) {
			return nilnul.num.real.matrix.MatrixX131113.Multiply(x, x);
		}
	}
}
