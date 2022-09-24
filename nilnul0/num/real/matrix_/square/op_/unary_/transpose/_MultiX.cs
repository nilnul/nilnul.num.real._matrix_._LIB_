using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square.op_.unary_.transpose
{
	static public class _MultiX
	{
		static public double[,] _TransposeMulti_assumeSquare(this double [,] matrix) {
			return nilnul.num.real.matrix.co_.multible._MultiX._Multiply_assumeSociable(
				nilnul.obj.matrix.op_.unary_.Transpose<double>.Singleton.op(
					matrix
				),
				matrix
			);
		}
	}
}