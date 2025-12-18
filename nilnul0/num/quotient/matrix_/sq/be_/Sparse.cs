using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.num.quotient.matrix_.sq.be_
{
	public class Sparse:sq.IBe
		, num.quotient.matrix.IBe 
		///

	{

		private num.quotient_.DenomNonnil _sparsity;

		public num.quotient_.DenomNonnil sparsity
		{
			get { return _sparsity; }
			set { _sparsity = value; }
		}

		public Sparse(Q4 sparsity)
		{
			this._sparsity=sparsity;
		}

		public bool _be_0sq(Q4[,] matrix) {

			int height = matrix.GetLength(0);
			var count = 0;
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < height; j++)
				{
					if (matrix[i,j] ==0)
					{
					count++;

					}
				}
			}

			return count >= height * height * this._sparsity; /// sparsity means 0s. eg: 1/2 means at least half of the entries are 0s.
		}
	}


}
