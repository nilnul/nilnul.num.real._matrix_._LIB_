using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.num.real.matrix_.sq.op_
{
	static public class _PonentX
	{
		public static R[,] _Ponent_0regular_1unneg(R[,] x, int pon) {
			var width = x.GetLength(0);

			if (width==0)
			{
				return x;
			}

			if (pon ==0)
			{
				return nilnul.num.real.matrix_.sq_._CanonicalX.GenerateAsReals(width);
			}

			if (pon ==1)
			{
				return x;
			}

			if (pon ==2)
			{
				return matrix_.sq.op_._SquareX._Square_0regular(x);
			}

			if (pon == 3)
			{
				return matrix.bi_._MultiX._Multiply_1sociable( matrix_.sq.op_._SquareX._Square_0regular(x),x);
			}

			var half = pon / 2;

			var remainder = pon % 2;

			var sq = matrix_.sq.op_._SquareX._Square_0regular(
				_Ponent_0regular_1unneg(x, half)
			);

			if (remainder==0)
			{
				return sq;
			}

			return matrix.bi_._MultiX._Multiply_1sociable(
				sq,x
			);
		}

		public static int[,] _Ponent_0regular_1unneg(int[,] x, int pon)
		{
			var width = x.GetLength(0);

			if (width == 0)
			{
				return x;
			}

			if (pon == 0)
			{
				return nilnul.num.real.matrix_.sq_._CanonicalX.GenerateAsInts(width);
			}

			if (pon == 1)
			{
				return x;
			}

			if (pon == 2)
			{
				return matrix_.sq.op_._SquareX._Square_0regular(x);
			}

			if (pon == 3)
			{
				return matrix.bi_._MultiX._Multiply_1sociable(matrix_.sq.op_._SquareX._Square_0regular(x), x);
			}

			var half = pon / 2;

			var remainder = pon % 2;

			var sq = matrix_.sq.op_._SquareX._Square_0regular(
				_Ponent_0regular_1unneg(x, half)
			);

			if (remainder == 0)
			{
				return sq;
			}

			return matrix.bi_._MultiX._Multiply_1sociable(
				sq, x
			);

		}
	}
}