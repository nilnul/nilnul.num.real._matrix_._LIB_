using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.sq.op_._adjugate
{
	/// <summary>
	/// 代数余子式矩阵
	/// </summary>
	static public  class _CofactorMatrixX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns>
		/// empty if matrix is empty
		/// </returns>
		static public Q[,] _CofactorMatrix_0equilat(Q[,] matrix) {


			int w = matrix.GetLength(0);

			var raw=
				obj.matrix_._SquareX._Init_0width<Q>(w)  /// cel is nul, but will be populated
				//real.matrix_.sq_._DefaultedX.Generate8quotient(matrix.GetLength(0))
			;

			for (int i = 0; i < w; i++)
			{
				for (int j = 0; j < w; j++)
				{
					raw[i, j] = sq.cel.remnant.minor._CofactorX._AssumeValid(matrix, i, j);
				}
				
			} //not executed if the result is empty.


			return raw;


			
		}

	}
}
