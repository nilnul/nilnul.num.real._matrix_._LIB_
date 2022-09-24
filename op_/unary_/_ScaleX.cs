using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M=nilnul.num.real.Matrix4dbl;

namespace nilnul.num.real.matrix.op_.unary_
{
	static public  class _ScaleX
	{
		public static void Scale(this double[,] matrix, double a)
		{


			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] *= a;
				}

			}
		}

		public static double[,] ScaleNew(this double[,] matrix, double a)
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
		public static double[,] Divide2new(this double[,] matrix, double a)
		{

			return ScaleNew( matrix,1/a);

		}

		static public M Op(double scale, M matrix){
			return new M(  ScaleNew(matrix, scale));
			
		}







	}
}
