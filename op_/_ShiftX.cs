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
	/// Note this is different from A+k, which is A+kI£¬while here we shift each cel.
	/// 
	/// </summary>
	/// alias:
	///		offset
	///		drift
	///		summon
	///			,sumon
	///	vs:
	///		shaft, subtract
	///		subside, which means add?
	static public  class _ShiftX
	{
		public static void Shift(this double[,] matrix, double a)
		{


			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] += a;
				}

			}
		}



		public static double[,] ShiftAsNew(this double[,] matrix, double a)
		{
			var r= matrix.Clone() as double[,];
			Shift(r, a);
			return r;

		}
		public static void Shift(this Q[,] matrix, Q a)
		{

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);


			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] += a;
				}

			}

		}

		public static Q[,] ShiftAsNew(this Q[,] matrix, Q a)
		{
			var r= matrix.Clone() as Q[,];
			Shift(r, a);
			return r;


		}













	}
}
