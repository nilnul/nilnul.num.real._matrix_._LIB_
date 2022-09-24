using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit;
using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.matrix.op
{
	public partial class Minus
	{
		static public Matrix1 Eval(Matrix1 a, Matrix1 b) {
			AssertX.Eq(a.dimension, b.dimension);
			

			return new Matrix1(_Eval(a.elementsToArray, b.elementsToArray));

			
		
		}

		static private double[,] _Eval(double[,] a, double [,] b) {

			double[,] r = new double[a.GetLongLength(0), a.GetLongLength(1)];

			for (int i = 0; i < r.GetLongLength(0); i++)
			{
				for (int j = 0; j < r.GetLongLength(1); j++)
				{
					r[i, j] = a[i, j] - b[i, j];
					
				}
				
			}
			return r;


		
		}


	}
}
