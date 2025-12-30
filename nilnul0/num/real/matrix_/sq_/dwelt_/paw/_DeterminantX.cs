using nilnul.num.quotient.str;
using nilnul.num.real.expr_.algebraic;
using nilnul.txt_.names.fro_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.matrix_.sq_.dwelt_.paw
{

	/// <summary>
	/// </summary>
	static public class _DeterminantX
	{
		/// <summary>
		/// some cel at the torso of the diagonal might be 0;
		/// </summary>
		/// <param name="paw"></param>
		/// <param name="index">m[p,p] is 0</param>
		/// <returns></returns>
		/// <see cref="real.matrix_.sq_.triag._DeterminantX"/>
		/// 
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _Determinant_0paw(
			//in   /// not in lamda
			Q4[,] paw)
		{

			/// <see cref="sq._determ_.by_.IBySubmatrix"/> of the row0
			IEnumerable<int> torso = Enumerable.Range(1, paw.GetLength(0)-1);

			/// <see cref="sq._determ_.by_.IBySubmatrix"/> of the row0
			return	nilnul.obj.matrix_.sq._DiagonalX._Diagonal_0sq(
					paw
				)._Product_0str()
				-
				/// the two swapped, hence the permutation is negative:
				nilnul.num.quotient.str._SumX.Sum(
					torso.Select(
						index =>paw[0, index]

						*   paw[index, 0]  /// the two swapped, hence the permutation is negative
						*
						quotient.bi_.mul._CumulaX._Cumulate_0str(
							torso.Where(j => j!=index).Select(
										k => paw[k, k]
							) /// others in the permutation.
						)
					)
				)
			;  



		}

	}
}
