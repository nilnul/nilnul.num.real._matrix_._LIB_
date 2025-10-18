using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// <see cref="matrix.op_.IIndent"/>
	/// 
	/// </summary>
	/// alias:
	///		echelon:<see cref="matrix.be_.IIndent"/>, <see cref="matrix_.dent_.indep_."/>
	///		indent
	///		gaussian
	///		Gauss–Jordan elimination
	///	vs:
	///		GramSchmidt process to get orthogonal basis, where the result here is not orthogonal in general; the Gram–Schmidt and Gaussian elimination can both be described as taking a given basis to a special basis; Gaussian transforms the matrix by making the subspace orthonormal, and Schmidt takes the superspace into account. eg: (0,1,1) and (1,0, 1) is orthonormal in (x,y), but not ortho nor normal in (x,y,z);  
	static public class _IndentX
	{



		/// <summary>
		/// each row is leading by 1. this is the reduced row echelon
		/// and the col with the leading 1 is  axial or not;
		/// </summary>
		/// <remarks>
		///  row echelon form may vary
		/// </remarks>
		/// <param name="m"></param>
		/// <returns> rank</returns>
		/// alias:
		///		right/upper triangle
		/// vs:
		///		echelon, where the leading can be not 1.
		static public int Indent(ref Q[,] m)
		{
			// get the first col
			// long col = 0;
			//	long row = 0;
			var rank = 0;

			var rows = m.GetLength(0);

			var cols = m.GetLength(1);

			for (var col = 0; col < cols; col++)
			{
				for (var row = rank; row < rows; row++)
				{
					Q head = m[row, col];
					if (head != 0)
					{
						_indent._GaussGramX._Swap(ref m, rank, row);  /// might be the same row; to make the row move upward.


						/// make all other rows 0
						///

						for (var remained = row + 1; remained < rows; remained++)
						{
							Q toCancel = m[remained, col];
							//if (toCancel != 0)
							//{
								_indent._GaussGramX._Skew_12row_3nilish(ref m, remained, rank,


									- toCancel/head								
								);   ///<see cref="nilnul.num.real.matrix.op_."/>
							//}
						}
						rank++;
						break;
					}
				}
			}
			return rank;
		}

	}
}
