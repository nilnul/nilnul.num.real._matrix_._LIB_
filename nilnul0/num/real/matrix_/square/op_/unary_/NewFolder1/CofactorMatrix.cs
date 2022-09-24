using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square
{
	[Obsolete(nameof(matrix_.square.op_.unary_.CofactorMatrix) )]
	public partial class CofactorMatrix
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns>
		/// empty if matrix is empty
		/// </returns>
		static public double[,] Eval(double[,] matrix) {

			var raw= Matrix.Ini(matrix.GetLength(0));

			for (int i = 0; i < raw.GetLength(0); i++)
			{
				for (int j = 0; j < raw.GetLength(1); j++)
				{
					raw[i, j] = Cofactor.Eval(matrix, i, j);
					
				}
				
			}


			return raw;


			
		}
	}
}
