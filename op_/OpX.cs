using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.doubleElement
{
	static public partial class Op_InMethods
	{
		public static double[] Multiply_rowVector( double[] vector, double[,] matrix)
		{
			return ToVector( 
				MatrixX.Multiply(
					MatrixX.ToMatrix(vector)
					,
					matrix
				)
			);


		}

		static public T[,] ToMatrix_rowVector<T>( T[] vector)
		{
			T[,] r = new T[1, vector.Length];
			for (int i = 0; i < r.GetLength(1); i++)
			{
				r[0, i] = vector[i];
			}
			return r;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="col"></param>
		/// <returns></returns>
		static public T[,] ToMatrix_colVector<T>(this T[] col)
		{
			return col.ToMatrix().Transpose();
		}



		public static double[] ToVector( double[,] x) {
			
			nilnul.bit.op.Assert.Eval(
				x.GetLength(1)==1	
			);

			double[] r=new double[ x.GetLength(0)];

			for (int i = 0; i < x.GetLength(0); i++)
			{
				r[i] = x[i, 0];
				
			}
			return r;


		}


	}
}
