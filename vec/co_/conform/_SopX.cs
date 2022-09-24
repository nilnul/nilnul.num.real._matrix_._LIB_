using nilnul.num.real.matrix.vec.co_.matrixMultible;
using nilnul.obj.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.vec.co_.conform
{

	///  
	/// <summary>
	/// sum of product. This is useful in <see cref="num.real.matrix.grid.co_.conform._MultiX"/>
	/// </summary>
	///  <seealso cref="nilnul.num.real.matrix.co_.multible.multi_.byGrid_._ByCompartX"/>

	static public class _SopX
	{

		/// <summary>
		/// convert the matrix into vecs. note on the right hand, the matrix is colwise.
		/// </summary>
		/// eg:
		/// 
		static public double[,] _Sop_assumeConform(
			IEnumerable<double[,]> belt
			,
			IEnumerable<double[,]> bunch
		)
		{

			var r = co_.matrixMultible._MultiComponentwiseX._Multi_assumeComponentwiseMultible(belt, bunch);


			if (r.Any())
			{
				return r.Aggregate(
					(a1,c) => matrix.co_.plusable._PlusX._Add_assumePlusable(a1,c)
				);
			}
			return new double[0, 0];


			//return matrix.grid.co_.conform.multi_.rows1cols_._VecInCompartX. _MultiAsMatrix_compartsAssumeSameProportioned(
			//	a.Select(
			//		//obj.matrix._RowsX.Rows()
			//		x => x.Rows()
			//	)
			//	,
			//	b.Select(
			//		y=>y.Cols()
			//	)
			//);
		}
	}
}
