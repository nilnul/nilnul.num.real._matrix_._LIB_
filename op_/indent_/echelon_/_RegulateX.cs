using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.indent_.echelon_
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
	///		<see cref="op_.indent_.echelon_.regula_._DedundantX"/>, this keeps the size information, which carries importance. Or maybe the rows count is not as important as cols count?
	///	vs:
	///		GramSchmidt process to get orthogonal basis, where the result here is not orthogonal in general; the Gram–Schmidt and Gaussian elimination can both be described as taking a given basis to a special basis; Gaussian transforms the matrix by making the subspace orthonormal, and Schmidt takes the superspace into account. eg: (0,1,1) and (1,0, 1) is orthonormal in (x,y), but not ortho nor normal in (x,y,z);  
	///		
	
	static public class _RegulateX
	{


		/// <summary>
		/// not only standard, but also the <see cref="matrix.be_.indep_."/>
		/// </summary>
		/// <param name="_rowEchelon">
		/// <see cref="indent_.IEchelon"/>
		/// </param>
		/// <param name="_rank"></param>
		static public void _Regulate_0echelon_1rank(ref Q[,] _rowEchelon, int _rank)
		{
			for (_rank -= 1; _rank >= 0; _rank--)
			{
				//get the one which is not zero.

				long firstNoneZero = num.real.matrix.row._PivotX.Pivot(ref _rowEchelon, _rank);


				//process this row.
				long row = _rank ;
				while (row-- > 0 )
				{
					_indent._GaussGramX._Skew_12row_3nilish(
						ref _rowEchelon, row, _rank, -_rowEchelon[row, firstNoneZero]
					);

				}

	

			}

		}

		static public void _Regulate_0echelon_1rank(ref Q[,] _rowEchelon, long _rank)
		{
			for (_rank -= 1; _rank >= 0; _rank--)
			{
				//get the one which is not zero.

				long firstNoneZero = num.real.matrix.row._PivotX.Pivot(ref _rowEchelon, _rank);


				//process this row.
				long row = _rank ;
				while (row-- > 0 )
				{
					_indent._GaussGramX._Skew_12row_3nilish(
						ref _rowEchelon, row, _rank, -_rowEchelon[row, firstNoneZero]
					);

				}

	

			}

		}

		/// <summary>
		/// the reduced row echelon form is unique.
		/// </summary>
		/// <param name="_rowEchelon"></param>
		/// <remarks>
		///  the returned, eg:
		///		[
		///			1,0,2,3
		///			0,1,0,1
		///			0,0,0,0
		///		]
		/// </remarks>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  void Regulate(ref Q[,] _rowEchelon)
		{
			 _Regulate_0echelon_1rank(
				 ref _rowEchelon, indent_._EchelonX.EchelonForRank(ref _rowEchelon) 
			);

		}
	


		//static public  void Regulate( Q[,] _rowEchelon)
		//{
		//	 Regulate(ref _rowEchelon );

		//}





	}
}
