using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.matrix.op
{
	public partial class Gaussian
	{
		static public void Canonical(Matrix1 m) {

			Trans(m.elments2);
		
		}

		static public void Canonical(double[,] m)
		{

			Trans(m);

		}

		static public Matrix1 Eval(Matrix1 m)
		{

			///find the biggest absolute value of the first column.
			///

			var t = m.elementsToArray;
			Eval(t);
			return new Matrix1(t);

		}
		static public void Trans(Matrix1 m)
		{

			///find the biggest absolute value of the first column.
			///

			Trans(m.elments2);



		}


		static public void Trans(double[,] m)
		{

			long rank = RowEchelon(m);

			_Canonical(m, rank);
			// now we have already got echelon.

			//it's time to get the standardized.



		}

		static public void Eval(double[,] m)
		{

			long rank = RowEchelon(m);

			_Canonical(m, rank);
			// now we have already got echelon.

			//it's time to get the standardized.



		}

		static public long RowEchelon(double[,] m)
		{

			//get the first col
			//long col = 0;
			//	long row = 0;
			long r = 0;
			for (long row = 0, col = 0; row < m.GetLongLength(0) - 1 && col < m.GetLongLength(1) - 1; row++, col++)
			{
				long biggestRow = Max(m, col, row);

				if (Math.Abs(m[biggestRow, col]) > 0)
				{
					//move the row forward
					Swap(m, biggestRow, row);
					//standardize the row.
					Scale(m, row, 1 / m[row, col]);
					///zero the next rows
					///
					//compute the ration
					double ratio;
					for (long i = row + 1; i < m.GetLongLength(0); i++)
					{
						ratio = -m[row + 1, col];

						Add(m, i, row, ratio);
					}
					r++;

				}
			}

			return r;


		}

		static public void Add(double[,] m, long augend, long addend)
		{

			for (long i = 0; i < m.GetLongLength(1); i++)
			{
				m[augend, i] += m[addend, i];

			}

		}

		static public void Add(double[,] m, long augend, long addend, double scale)
		{

			for (long i = 0; i < m.GetLongLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];

			}

		}



		static private void _Canonical(double[,] _rowEchelon, long _rank)
		{
			for (_rank -=1; _rank >= 0 ; _rank--)
			{
				//get the one which is not zero.

				long firstNoneZero = FirstNonZero(_rowEchelon, _rank);


				//process this row.

				for (long row = _rank-1; row >=0; row--)
				{
					Add(_rowEchelon, row, _rank, -_rowEchelon[row, firstNoneZero]);

				}


			}



		}

		static public long FirstNonZero(double[,] matrix, long row)
		{
			for (long i = 0; i < matrix.GetLongLength(1); i++)
			{
				if (matrix[row, i] != 0)
				{
					return i;

				}

			}
			return -1;


		}



		static public void Scale(double[,] m, long row, double scale)
		{

			for (int i = 0; i < m.GetLongLength(1); i++)
			{
				m[row, i] *= scale;

			}

		}



		static public void Swap(double[,] m, long i, long j)
		{

			for (long k = 0; k < m.GetLongLength(1); k++)
			{
				SwapX.Swap(ref m[i, k], ref m[j, k]);

			}

		}

		static public long Max(double[,] m, long col)
		{

			long r = 0;
			double element = 0;
			for (long i = 0; i < m.GetLongLength(0); i++)
			{
				r = Math.Abs(m[i, col]) > element ? i : r;

			}
			return r;



		}


		static public long Max(double[,] m, long col, long rowToBegin)
		{

			long maxRow = rowToBegin;
			double element = m[rowToBegin, col];


			for (maxRow = rowToBegin; rowToBegin < m.GetLongLength(0); rowToBegin++)
			{

				maxRow = Math.Abs(m[rowToBegin, col]) > element ? rowToBegin : maxRow;

			}
			return maxRow;



		}
	}
}
