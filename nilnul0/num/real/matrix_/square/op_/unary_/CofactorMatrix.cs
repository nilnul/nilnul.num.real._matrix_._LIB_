using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.square.op_.unary_
{
	public  class CofactorMatrix
		:
		nilnul.num.real.matrix_.square.op_.Unary4dblI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns>
		/// empty if matrix is empty
		/// </returns>
		static public double[,] Matrix4dbl(double[,] matrix) {


			var raw= real.matrix_.square_.init.of_._OfDimensionX.OfDimension(matrix.GetLength(0));

			for (int i = 0; i < raw.GetLength(0); i++)
			{
				for (int j = 0; j < raw.GetLength(1); j++)
				{
					raw[i, j] = square.cel.remnant.minor._CofactorX._AssumeValid(matrix, i, j);
					
				}
				
			} //not executed if the result is empty.


			return raw;


			
		}

		public Square4dbl op(Square4dbl par)
		{
			return new Square4dbl(
				Matrix4dbl(par)
			);
			//throw new NotImplementedException();
		}


		static public CofactorMatrix Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CofactorMatrix>.Instance;
			}
		}

	}
}
