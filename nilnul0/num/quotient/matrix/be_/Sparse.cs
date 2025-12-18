using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix.be_
{
	public class Sparse:
		 num.quotient.matrix.BeI 
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

	
		public bool be(in Q4[,] val)
		{

			int height = val.GetLength(0);
			var width = val.GetLength(1);

			var count = 0;
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if (val[i,j] ==0)
					{
						count++;
					}
				}
			}

			return count >= height * width * this._sparsity; /// sparsity means 0s. eg: 1/2 means at least half of the entries are 0s.
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Sparse CreateHalf() {
			return new Sparse( quotient_._InvertX.HALF);
		}
	}


}
