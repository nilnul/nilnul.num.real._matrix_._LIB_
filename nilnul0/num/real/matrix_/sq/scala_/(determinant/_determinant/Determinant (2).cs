using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using nilnul20080301.linearAlgebra;


namespace nilnul20080301.linearAlgebra
{
	public class Determinant
	{

		public static double Compute(double[,] squareMatrix)
		{
			if (squareMatrix.GetLength(0) != squareMatrix.GetLength(1))
			{
				throw new Exception("The matrix must be square.");
			}

			if (squareMatrix.GetLength(0) == 0)
			{
				throw new Exception("The square matrix must be 1 or more in width.");
			}

			//suppose it's one in length.
			if (squareMatrix.GetLength(0) == 1)
			{

				return squareMatrix[0, 0];
			}
			else
			{
				double r = 0;
				for (int i = 0; i < squareMatrix.GetLength(0); i++)
				{
					r += squareMatrix[0, i] * Math.Pow(-1, i) * Compute(Matrix_Extension.Cofactor(squareMatrix, 0, i));
				}
				return r;
			}





		}



	}//class
}
