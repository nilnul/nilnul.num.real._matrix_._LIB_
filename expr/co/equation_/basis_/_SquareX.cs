using nilnul.obj.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.expr.co.equation_.basis_
{
	/// <summary>
	///A is square and  invertible.
	///This can map the whole space to itself.
	/// </summary>
	static public class _SquareX
	{
		static public IEnumerable< double> Sln(double[,] matrix, double[] oldCoord) {
			return nilnul.num.real.matrix.co_.multible._MultiX._Multiply_assumeSociable(
				real.matrix_.square_.invertible.op_.unary_.Invert._Matrix_assumeSquare1invertible(matrix)
				,
				nilnul.num.real.matrix_._ColX.Matrix4dbl(
					oldCoord
				)
			).Cols().First();

		}
	}
}
