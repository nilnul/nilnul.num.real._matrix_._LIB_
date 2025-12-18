using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix.husk
{
	static public class _HasX
	{
		/// <summary>
		/// not whether the cols is in the cols, but in the husk.
		/// </summary>
		/// <remarks>
		/// whether col can be linearly combinated by the matrix cols;
		/// </remarks>
		/// <param name="matrix"></param>
		/// <param name="col">
		/// a col (row transposed), not a row.
		/// </param>
		/// <returns></returns>
		static public bool _Has_1equihigh(Q4[,] matrix, Q4[] col) {

			///<see cref="real.matrix.re_._EquiHullX"/>
			///
			/// or see if the Ax =b has solution, 
			/// ,<see cref="quotient.matrix.hu"/>
			/// 

			var ratio = nilnul.obj.matrix_.isohigh.bi_._JuxtaposeX._Juxtapose_1isohighCol(matrix, col);  /// A\b

			var rank = 
				nilnul.num.real.matrix.op_.dent_.echelon_._VentX.Vent(ref ratio)
				///nilnul.num.real.matrix.op_.vent_._indep_.by_._GaussianX.ToIndepVent(frac)
				;




			/// 
			/// zero rows (0=0) are removed.
			/// 
			if (rank ==0)
			{

				return true;	/// it's solvable.  0*c matric has 0*1 col. 
			}



			if (
				nilnul.num.real.matrix.row._PivotX.Pivot(
				in ratio, rank - 1
				) == matrix.GetLength(1))
			{
				/// 0 \1;
				/// unsatisfiable;
				/// 
				return false;   
			}

			return true;

		}
	}
}
