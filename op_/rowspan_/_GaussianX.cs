using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.rowspan_
{
	/// <summary>
	/// <see cref="matrix.op_.IIndent"/>
	/// 
	/// </summary>
	/// alias:
	///		echelon:<see cref="matrix.be_.IIndent"/>, <see cref="matrix_.indent_.indep_."/>
	///		indent
	///		gaussian
	///		Gauss–Jordan elimination
	///	vs:
	///		GramSchmidt process to get orthogonal basis, where the result here is not orthogonal in general; the Gram–Schmidt and Gaussian elimination can both be described as taking a given basis to a special basis; Gaussian transforms the matrix by making the subspace orthonormal, and Schmidt takes the superspace into account. eg: (0,1,1) and (1,0, 1) is orthonormal in (x,y), but not ortho nor normal in (x,y,z);  
	static public class _GaussianX
	{


		/// <summary>
		/// not only standard, but also the <see cref="matrix.be_.indep_."/>
		/// </summary>
		/// <param name="_rowEchelon"></param>
		/// <param name="_rank"></param>
		static  void _Canonical_1rank(ref Q[,] _rowEchelon, long _rank)
		{
			for (_rank -= 1; _rank >= 0; _rank--)
			{
				//get the one which is not zero.

				long firstNoneZero = Pivot(ref _rowEchelon, _rank);


				//process this row.

				for (long row = _rank - 1; row >= 0; row--)
				{
					Absorb(_rowEchelon, row, _rank, -_rowEchelon[row, firstNoneZero]);

				}


			}

		}

		/// <summary>
		/// the reduced row echelon form is unique.
		/// </summary>
		/// <param name="_rowEchelon"></param>
		static public  void Canonical(ref Q[,] _rowEchelon)
		{
			 _Canonical_1rank(ref _rowEchelon, Standardize(_rowEchelon) );

		}
		static public  void Canonical( Q[,] _rowEchelon)
		{
			 Canonical(ref _rowEchelon );

		}


		/// <summary>
		/// called pivot.
		/// get the index of the first col that is not zero.
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="row"></param>
		/// <returns></returns>
		/// alias:
		///		firstUnnil
		static public long Pivot(ref Q[,] matrix, long row)
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

		/// <summary>
		/// each row is leading by 1. this is the reduced row echelon
		/// and the col with the leading 1 is  axial or not;
		/// </summary>
		/// <remarks>
		///  row echelon form may vary
		/// </remarks>
		/// <param name="m"></param>
		/// <returns> rank</returns>
		/// vs:
		///		echelon, where the leading can be not 1.
		static public long Standardize(Q[,] m)
		{
			// get the first col
			// long col = 0;
			//	long row = 0;
			long rank = 0;

			long rows = m.GetLongLength(0);

			long cols = m.GetLongLength(1);

			for (long col = 0; col < cols; col++)
			{
				for (long row = rank; row < rows; row++)
				{
					Q head = m[row, col];
					if (head != 0)
					{
						Swap(ref m, rank, row);
						Scale(ref m, rank, head.toInverse());

						/// make all other rows 0
						///

						for (long remained = row + 1; remained < rows; remained++)
						{
							Q toCancel = m[remained, col];
							if (toCancel != 0)
							{
								Absorb(m, remained, rank,
									-toCancel								// /head  =1
								);
							}
						}
						rank++;
						break;
					}
				}
			}
			return rank;
		}

		static public void Absorb(double[,] m, long augend, long addend)
		{

			for (long i = 0; i < m.GetLongLength(1); i++)
			{
				m[augend, i] += m[addend, i];

			}

		}
		static public void Absorb(Q[,] m, long augend, long addend)
		{

			for (long i = 0; i < m.GetLongLength(1); i++)
			{
				m[augend, i] += m[addend, i];

			}

		}


		static public void Absorb(double[,] m, long augend, long addend, double scale)
		{

			for (long i = 0; i < m.GetLongLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];

			}

		}


		static public void Absorb(Q[,] m, long augend, long addend, Q scale)
		{

			for (long i = 0; i < m.GetLongLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];

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
		static public void Scale(ref Q[,] m, long row, Q scale)
		{
			if (scale == 1)
			{
				return;
			}
			_Scale_2untrivia(m, row, scale);
		}

		static public void _Scale_2untrivia(Q[,] m, long row, Q scale)
		{

			for (int i = 0; i < m.GetLongLength(1); i++)
			{
				m[row, i] *= scale;

			}
		}

		static public void Scale(double[,] m, long row, double scale)
		{

			for (int i = 0; i < m.GetLongLength(1); i++)
			{
				m[row, i] *= scale;
			}
		}

		static public void _Swap_2dif(ref Q[,] m, long i, long j)
		{
			for (long k = 0; k < m.GetLongLength(1); k++)
			{
				SwapX.Swap(ref m[i, k], ref m[j, k]);
			}



		}

		static public void Swap(ref Q[,] m, long i, long j)
		{
			if (i == j)
			{
				return;

			}
			_Swap_2dif(ref m, i, j);

		}


		static public void Swap(double[,] m, long i, long j)
		{
			for (long k = 0; k < m.GetLongLength(1); k++)
			{
				SwapX.Swap(ref m[i, k], ref m[j, k]);
			}
		}
	}
}
