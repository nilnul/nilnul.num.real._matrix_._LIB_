using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.seq_.headed_.nonhead8pos.fractile.convergent.theorem_
{
	/*
	 https://mathworld.wolfram.com/Convergent.html

	 */
	/// <summary>
	/// the convergent is the quotient of two matrix, each of which is derived from the adders till current;
	/// </summary>
	/// 
	internal class ByMatrix
	{

		static public BigInteger[,] _SquareMatrix_0diagonal(
			IEnumerable< BigInteger> matrix
		)
		{
			var width = matrix.Count();

			var r = new BigInteger[width, width];

			for (int i = 0; i < width; i++)
			{
	
					r[i, i] = matrix.ElementAt(i);
			}


			var widthMinus = width - 1;
			for (int i = 0; i < widthMinus; i++)
			{
				r[width, i] = r[i, width] = 0;
			}

			for (int i = 1; i < width; i++)
			{
				r[i, i - 1] = 1;
			}
			for (int i =0; i < widthMinus; i++)
			{
				r[i, i + 1] = -1;
			}


			return r;
		}

	

		static public Quotient1 _LastConvergent_0adders(
			IEnumerable<BigInteger> adders
		)
		{
			return 				nilnul.num.real.matrix_.sq.to_.scalar_._DeterminantX.Determinant(
					_SquareMatrix_0diagonal(adders)
				).current.mid
				/
	nilnul.num.real.matrix_.sq.to_.scalar_._DeterminantX.Determinant(
					_SquareMatrix_0diagonal(adders.Skip(1))
				).current.mid
			;
		}
	}
}
