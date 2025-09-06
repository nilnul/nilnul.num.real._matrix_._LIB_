using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.op_
{

	public class _Congruence4dbl
		
	{
		private double[,] _invertible;

		public double[,] invertible
		{
			get { return _invertible; }
			set { _invertible = value; }
		}

		private double[,] _transposedCached;

		public double[,] transposed
		{
			get { return _transposedCached; }
		}

		public _Congruence4dbl(double[,] _invertible)
		{
			this._invertible = _invertible;
			this._transposedCached = matrix.op_.unary_.Transpose.Op(_invertible);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">
		/// it has to be square, and the size is compatible;
		/// </param>
		/// <returns></returns>
		double[,] _op_0sociable(double[,] x) {
			return _CongruentX._Congruent_0invertible_1transposed_2sociable(
				_invertible
				,
				_transposedCached
				,
				x
			);
		}


	}
}
