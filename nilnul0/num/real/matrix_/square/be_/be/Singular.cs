using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square.be
{
	public partial class Singular
	{
		static public bool Eval(double[,] matrix) {
			return Determinant.Eval(matrix) == 0;
		}
	}
}
