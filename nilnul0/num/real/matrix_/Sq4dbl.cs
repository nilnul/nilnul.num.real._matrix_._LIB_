using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_
{
	public  class Square4dbl
		:nilnul.num.real.matrix.be_.square.vow.Ee4dbl
	{
		public Square4dbl(double[,] x)
			:base(x)
		{

		}

		
		static public Square4dbl OfEls(params double[] elements) {
			var width =nilnul.num.natural.op.unary.SqrtFloorX.Eval(elements.Length);

			var array = new double[width,width];
			for (int i = 0; i < elements.Length; i++)
			{
				array[i / width, i % width] = elements[i];

				
			}
			return new Square4dbl(array);
		}
		

		static public double[,] CreateIdentity(int dimension) {

			var r = new double[dimension, dimension];
			for (int i = 0; i < dimension; i++)
			{
				for (int col = 0; col < dimension; col++)
				{
					if (i==col)
					{
						r[i, col] = 1;
					}
					else
					{
						r[i, col] = 0;
					}
				}
			}
			return r;

		}

		
	}
}
