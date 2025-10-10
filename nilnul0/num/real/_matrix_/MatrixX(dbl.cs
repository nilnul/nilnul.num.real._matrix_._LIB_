using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.doubleElement
{
	/// <summary>
	/// This will regard two-dimensional arrays as Matrix and define matrix computation.
	/// The mothods we defined on our matrix class is not applicable on these arrays for they are built in CLR types; however we convert or box them as matrix and compute, then unbox back.
	/// </summary>
	///
	[Obsolete()]
	static public  class MatrixX
	{

	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns></returns>
		public static double[,] Adjoint(this double[,] matrix)
		{

			//it has to be square

			int n = matrix.GetLength(0);

			if (matrix.GetLength(1) != n)
			{
				throw new Exception("The matrix has to be square.");
			}


			double[,] r = new double[matrix.GetLength(1), matrix.GetLength(0)];

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = matrix.AlgebraicCofactor(j, i);
				}
			}
			return r;

		}



		public static double[,] Cofactor(this double[,] matrix, int m, int n)
		{
			double[,] r = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
			for (int i = 0; i < r.GetLength(0); i++)
			{
				if (i < m)
				{
					for (uint j = 0; j < r.GetLength(1); j++)
					{

						if (j < n)
						{
							r[i, j] = matrix[i, j];
						}
						else
						{
							r[i, j] = matrix[i, j + 1];
						}

					}
				}
				else
				{
					for (int j = 0; j < r.GetLength(1); j++)
					{

						if (j < n)
						{
							r[i, j] = matrix[i + 1, j];
						}
						else
						{
							r[i, j] = matrix[i + 1, j + 1];
						}

					}


				}

			}
			return r;

		}//Cofactor

		public static double AlgebraicCofactor(this double[,] squareMatrix, int m, int n)
		{

			//if (!squareMatrix.IsSquare()) {
			//    throw new Exception("The matrix must be square.");
			//}
			if ((m % 2) == (n % 2))
			{
				return Cofactor(squareMatrix, m, n).Determinant();
			}
			else
			{
				return -Cofactor(squareMatrix, m, n).Determinant();

			}




		}

		public static double[,] Inverse(this double[,] matrix)
		{
			if (!IsSquare(matrix))
			{
				throw new Exception("The matrix is not square.");
			}
			double determ = matrix.Determinant();

			if (determ == 0)
			{
				throw new Exception("The determinant of the matrix is 0 so it's not inversible.");
			}

			if (matrix.GetLength(0) == 1)
			{
				return new double[,] { { 1 / matrix[0, 0] } };

			}
			else
			{

				return (1.0 / determ).Multiply(matrix.Adjoint());

			}




		}

		/// <summary>
		/// A real number times a Matrix
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="a"></param>
		/// <returns></returns>
		public static double[,] Multiply(this double[,] matrix, double a)
		{

			double[,] r = new double[matrix.GetLength(0), matrix.GetLength(1)];

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = matrix[i, j] * a;
				}

			}
			return r;

		}

		/// <summary>
		/// A real number times a matrix
		/// </summary>
		/// <param name="a"></param>
		/// <param name="matrix"></param>
		/// <returns></returns>
		public static double[,] Multiply(this double a, double[,] matrix)
		{

			double[,] r = new double[matrix.GetLength(0), matrix.GetLength(1)];

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = matrix[i, j] * a;
				}

			}
			return r;

		}

		public static double[,] Multiply_rowVector(this double[] vector, double[,] matrix)
		{
			return  Multiply(ToMatrix(vector), matrix);


		}



		public static bool IsSquare(this double[,] matrix)
		{
			return matrix.GetLength(0) == matrix.GetLength(1);
		}

		public static double Determinant(this double[,] squareMatrix)
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
					r += squareMatrix[0, i] * squareMatrix.AlgebraicCofactor(0, i);
				}
				return r;
			}

		}

		static public T[,] ToMatrix<T>(this T[] vector) {
			T[,] r = new T[1, vector.Length];
			for (int i = 0; i < r.GetLength(1);i++ )
			{
				r[0, i] = vector[i];
			}
			return r;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="vector"></param>
		/// <returns></returns>
		static public T[,] ToMatrixVertical<T>(this T[] vector)
		{
			return vector.ToMatrix().Transpose();
		}




		static public double[,] Multiply(this double[,] a, double[,] b)
			
			
		{
			if (a.GetLength(1) != b.GetLength(0))
			{
				throw new Exception("arg[0].GetLength(1)!=arg[1].GetLength(0).");
			}

			int n = a.GetLength(1);

			double[,] r = new double[a.GetLength(0), b.GetLength(1)];
			double c;

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (uint j = 0; j < r.GetLength(1); j++)
				{
					c = 0;
					for (int k = 0; k < a.GetLength(1); k++)
					{
						c += a[i, k] * b[k, j];
					}
					r[i, j] = c;

				}
			}
			return r;
		}



		static public T[,] Transpose<T>(this T[,] matrix) {
			T[,] r = new T[matrix.GetLength(1), matrix.GetLength(0)];
			for (int i = 0; i < r.GetLength(0);i++ )
			{
				for (int j = 0; j < r.GetLength(1); j++) {
					r[i, j] = matrix[j, i];
				}
			}
			return r;
		}


		static public string toString<T>(this T[,] matrix)
		{
			string seperator = ",";
			string r = "";
			r += "{";
			for (uint i = 0; i < matrix.GetLength(0); i++)
			{
				r += "{";

				for (uint j = 0; j < matrix.GetLength(1); j++)
				{
					r += matrix[i, j];
					r += ",";
				}
				r = r.Remove(r.Length - seperator.Length);
				r += "}";
				r += ",";
			}
			r = r.Remove(r.Length - seperator.Length);
			r += "}";
			return r;

		}



	}//class



}
