using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec.compart.str.co.cartesian.map_
{
	///
	///<summary>
	///partition each matrix.
	/// </summary>
	/// <remarks>
	/// used by:
	///  <seealso cref="nilnul.num.real.matrix.co_.multible.multi_.byGrid_._ByCompartX"/>
	/// </remarks>
	///alias:
	///	by grouping
	///	by compart
	///	<see cref="nilnul.num.real.matrix.vec.co_.conform._Belt1bunchX"/>
	public class _InnerProductEsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="belt">
		/// <see cref="grid_.IBelt"/>
		/// every row is sliced.
		///
		/// </param>
		/// <param name="bunch">
		/// a matrix.grid, single bunch. each col is split.
		/// size eq to that of <paramref name="belt"/>
		/// 
		/// </param>
		/// <returns></returns>
		static public IEnumerable<IEnumerable< double>> _Multi_assumeDwelt1CompartsSamePortioned(
			IEnumerable<
				IEnumerable<IEnumerable<double>>   //compart as vec
			>
			belt
			,
			IEnumerable<
				IEnumerable<IEnumerable<double>>  //compart as vec
			>
			bunch
		)
		{
			return belt.Select(
				r=>
				bunch.Select(
					c=> num.real.vec.compart.co._InnerProductX._InnerProduct_assumeComparts(r,c)
				)
			);
		}

		static public  double[,] _MultiAsMatrix_compartsAssumeSameProportioned(
			IEnumerable<
				IEnumerable<IEnumerable<double>>   //compart as vec
			>
			majors
			,
			IEnumerable<
				IEnumerable<IEnumerable<double>>  //compart as vec
			>
			minors
		)
		{
			var r1= majors.Select(
				r=>
				minors.Select(
					c=> num.real.vec.compart.co._InnerProductX._InnerProduct_assumeComparts(r,c)
				)
			);
			if (r1.Any())
			{
				return obj.matrix.of_.vecs_._OfRowsX._OfVecs_assumeSameArity(r1);
			}
			return new double[0 , minors.Count() ];
		}




	}
}
