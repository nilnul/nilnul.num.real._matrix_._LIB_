using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.dent_.echelon_.indep_
{
	static public class _VentX
	{


		/// <summary>
		/// </summary>
		/// <param name="_rowEchelonIndep"></param>
		/// <param name="_rank"></param>
		/// <remarks>
		/// </remarks>
		static public void _Vent_0echelonIndep(ref Q[,] _rowEchelonIndep)
		{
			var rows = _rowEchelonIndep.GetLength(0);


			while (rows-->0)
			{

				long firstNoneZero = num.real.matrix.row._PivotX.Pivot(ref _rowEchelonIndep, rows);


				//process this row.
				long row = rows ;
				while (row-- > 0 )
				{
					_indent._GaussGramX._Skew_12row_3nilish(
						ref _rowEchelonIndep, row, rows, -_rowEchelonIndep[row, firstNoneZero]
					);

				}


			}
			

		}

		/// <summary>
		/// the reduced row echelon form is unique.
		/// </summary>
		/// <param name="m"></param>
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
		static public Q[,] ToIndepVent( Q[,] m)
		{

			var std = echelon_._DedundantX.ToIndepEchelon( m);
			_Vent_0echelonIndep(ref std);

			return std;



		}
	







	}
}
