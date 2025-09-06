using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M = nilnul.num.real.Matrix4dbl;

namespace nilnul.num.real.matrix.op_.unary_
{
	static public class _NegX
	{
		public static void NegateSelf(this double[,] matrix)
		{

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = -matrix[i, j];
				}

			}
		}

		public static double[,] NegateAsNew(this double[,] matrix)
		{

			double[,] r = (double[,])matrix.Clone();
			NegateSelf(r);
			return r;

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = -matrix[i, j];
				}

			}
			return r;









		}
	}
}
