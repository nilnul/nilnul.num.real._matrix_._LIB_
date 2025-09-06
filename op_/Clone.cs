using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.unary_
{
	static public class _CloneX
	{
		static public double[,] Clone(double [,] m) {
			return nilnul.obj.matrix.op_.unary_.Clone<double>.Op(m);
		}

		internal static int[,] Clone(int[,] m)
		{
			return nilnul.obj.matrix.op_.unary_.Clone<int>.Op(m);

		}
	}
}
