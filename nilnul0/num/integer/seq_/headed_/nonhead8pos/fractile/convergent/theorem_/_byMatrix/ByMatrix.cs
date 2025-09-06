using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.seq_.headed_.nonhead8pos.fractile.convergent.theorem_._byMatrix
{
	/*
	 https://mathworld.wolfram.com/Convergent.html

	 */
	/// <summary>
	/// 
	/// </summary>
	/// 
	internal class ByMatrix
	{

	

		static public BigInteger[,] _SquareMatrix_0current_1nextAdder(
			BigInteger[,] matrix, BigInteger nextAdder
		)
		{
			var width = matrix.GetLength(0);
			var widthPlus = width + 1;
			var r = new BigInteger[widthPlus, widthPlus];
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < width; i++)
				{
					r[i, j] = matrix[i, j];
				}
			}

			var widthMinus = width - 1;
			for (int i = 0; i < widthMinus; i++)
			{
				r[width, i] = r[i, width] = 0;
			}

			r[widthMinus, width] = -(r[width, widthMinus] = 1);

			r[width, width] = nextAdder;
			return r;
		}

		static public IEnumerable<BigInteger[,]> _SquareMatrix_0adders(
			IEnumerator<BigInteger> adders
		)
		{
			adders.MoveNext();
			var headMatrix = new BigInteger[1, 1] { { adders.Current } };
			yield return headMatrix;

			while (adders.MoveNext())
			{
				yield return headMatrix = _SquareMatrix_0current_1nextAdder(
					headMatrix, adders.Current
				);
			}
		}

		static public IEnumerable<BigInteger[,]> _SquareMatrixEs_0adders(
			IEnumerable<BigInteger> adders
		)
		{
			return _SquareMatrix_0adders(adders.GetEnumerator());
		}

		
	}
}
