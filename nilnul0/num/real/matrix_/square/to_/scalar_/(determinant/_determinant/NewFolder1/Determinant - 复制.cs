using nilnul.num.real.matrix.square;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using R = nilnul.num.RealI;

using nilnul.num.real.matrix;

namespace nilnul.num.real.matrix_.square
{
	[Obsolete(nameof(square.to_.scalar_._DeterminantX))]
	public class Determinant
	{
		public static double Eval(params double[] squareMatrix) {

			return nilnul.num.real.matrix.square.InDouble.Create(squareMatrix).determinant;
		}

		public static double _Eval_2x2(double[] v0, double[] v1) {

			return InDouble.Create(v0[0], v0[1], v1[0], v1[1]).determinant;

		
		}

		public static float Eval_2x2(float x,float x1, float y,float y1) {

			return x*y1-x1*y;

		
		}

		public static R Eval_2x2(R x,R x1, R y, R y1) {

			return x.Multi( y1 ).Minus( x1.Multi(y));

		
		}




		//public static double _Eval_triangluarDecomposition(double[,] squareMatrix) {
		//	throw new NotImplementedException();
		//}
	

		
		//public static R _Eval_laplace(R[,] squareMatrix)
		//{

		//	if (squareMatrix.GetLength(0) == 0)
		//	{
		//		return new nilnul.num.real_.Quotient( 1);
		//	}

		//	else
		//	{
		//		var  r = new nilnul.num.real_.Quotient();

		//		for (int i = 0; i < squareMatrix.GetLength(0); i++)
		//		{
		//			r += squareMatrix[0, i] * Cofactor.Eval(squareMatrix,0,i)  ;
		//		}
		//		return r;
		//	}
		//}

		public static double Eval(double[,] squareMatrix)
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
					r += squareMatrix[0, i] * Math.Pow(-1, i) * Eval(MatrixX131113.Cofactor(squareMatrix, 0, i));
				}
				return r;
			}
		}
	}//class
}
