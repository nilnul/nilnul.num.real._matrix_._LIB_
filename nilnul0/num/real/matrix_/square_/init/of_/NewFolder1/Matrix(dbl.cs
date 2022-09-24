using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M = nilnul.num.real.matrix.Matrix;

namespace nilnul.num.real.matrix.square
{
	[Obsolete(
		nameof(real.matrix_.square_.init.of_._OfDimensionX)
	)]
	public  class Matrix
		:nilnul.bit.AdjectiveType2<nilnul.num.real.matrix.Matrix,Square>
	{
		M _matrix;
		public Matrix(M matrix)
			:base(matrix)
		{


		}

		static public double[,] Ini(int dimension) {
			return new double[dimension, dimension];
		
		}
	}
}
