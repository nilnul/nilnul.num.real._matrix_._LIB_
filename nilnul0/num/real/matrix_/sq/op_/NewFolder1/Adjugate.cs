using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square
{
	/// <summary>
	/// 
	/// </summary>
	/// 伴随矩阵
	///
	[Obsolete()]
	public partial class Adjugate
	{

		static public double[,] Eval(double[,] matrix) {

			return MatrixX131113.Transpose(CofactorMatrix.Eval(matrix));
		
		}
	}
}
