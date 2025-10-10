using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.indent_.echelon_.dedund_
{
	static public class _RegulateX
	{


		/// <summary>
		/// not only standard, but also the <see cref="matrix.be_.indep_."/>
		/// </summary>
		/// <param name="_rowEchelon"></param>
		/// <param name="_rank"></param>
		/// <remarks>
		///  as canonical
		/// </remarks>
		static public void _Regulate_0std(ref Q[,] _rowEchelon)
		{
			var rows = _rowEchelon.GetLength(0);


			while (rows-->0)
			{

				long firstNoneZero = num.real.matrix.row._PivotX.Pivot(ref _rowEchelon, rows);


				//process this row.
				long row = rows ;
				while (row-- > 0 )
				{
					_indent._GaussGramX._Skew_12row_3nilish(
						ref _rowEchelon, row, rows, -_rowEchelon[row, firstNoneZero]
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
		static public Q[,] Regulate( Q[,] _rowEchelon)
		{

			var std = echelon_._DedundantX.ToStd( _rowEchelon);
			_Regulate_0std(ref std);

			return std;



		}
	







	}
}
