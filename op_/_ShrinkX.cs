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
	/// </summary>
	/// alias:
	///		<see cref="real.matrix.op_.ISquash"/>
	///		shred, reserved for :<see cref="op_.stretch_.IShaft"/>
	static public  class _ShrinkX
	{
		public static void _Shrink_1divisor(this double[,] matrix, double a)
		{


			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] /= a;
				}

			}
		}



		public static double[,] _ShrinkAsNew_1divisor(this double[,] matrix, double a)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			double[,] r = new double[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] = matrix[i, j] / a;
				}

			}
			return r;

		}

		public static Q[,] ShrinkAsNew(this Q[,] matrix, Q a)
		{

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			Q[,] r = new Q[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] = matrix[i, j] / a; /// if a is 0, exception
				}

			}
			return r;

		}
		public static void Shrink(this Q[,] matrix, Q a)
		{

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);


			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] /= a;
				}

			}

		}











	}
}
