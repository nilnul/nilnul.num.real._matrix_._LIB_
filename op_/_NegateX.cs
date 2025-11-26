using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M = nilnul.num.real.Matrix4dbl;

namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// shrink by -1
	/// </summary>
	static public class _NegateX
	{
		public static void Negate(ref double[,] matrix)
		{

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = -matrix[i, j];
				}

			}
		}

		public static double[,] Negate(this double[,] matrix)
		{

			double[,] r = (double[,])matrix.Clone();
			Negate(r);
			return r;

		}
	}
}
