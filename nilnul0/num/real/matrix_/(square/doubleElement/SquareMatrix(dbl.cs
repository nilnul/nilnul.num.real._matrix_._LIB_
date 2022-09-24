using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.doubleElement
{
	[Obsolete()]
	public  class SquareMatrix
		:nilnul.bit.op.predicate.unary.Asserted<double[,],nilnul.collection.matrix.twoDimensionalArray._be.Square<double>>
	{
		public SquareMatrix(double[,] x)
			:base(x)
		{

		}

		public double determinant {
			get
			{
				return nilnul.num.real.matrix.square.Determinant.Eval(this.val);
			}

			
		}
		static public SquareMatrix Create(params double[] elements) {
			var width =nilnul.num.natural.op.unary.SqrtFloorX.Eval(elements.Length);

			var array = new double[width,width];
			for (int i = 0; i < elements.Length; i++)
			{
				array[i / width, i % width] = elements[i];

				
			}
			return new SquareMatrix(array);
		}
		
	}
}
