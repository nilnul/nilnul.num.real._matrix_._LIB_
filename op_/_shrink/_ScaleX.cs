using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using M=nilnul.num.real.Matrix4dbl;

namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// <see cref="nilnul.num.real.matrix.bi_._MultiX"/> of <see cref="num.real.matrix_.sq_.IScaler"/>, and <see cref="nilnul.num.real.IMatrix"/>
	/// </summary>
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



		public static double[,] ScaleAsNew(this double[,] matrix, double a)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			double[,] r = new double[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] = matrix[i, j] * a;
				}

			}
			return r;

		}

		public static Q[,] ScaleAsNew(this Q[,] matrix, Q a)
		{

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			Q[,] r = new Q[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] = matrix[i, j] * a;
				}

			}
			return r;

		}
		public static void Scale(this Q[,] matrix, Q a)
		{

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);


			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] *= a;
				}

			}

		}




		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double[,] DivideAsNew(this double[,] matrix, double a)
		{

			return ScaleAsNew( matrix,1/a);

		}









	}
}
