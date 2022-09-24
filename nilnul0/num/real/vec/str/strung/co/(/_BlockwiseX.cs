using nilnul.num.real.matrix.co_.multible.multi_;
using nilnul.num.real.vec.str.co;
using nilnul.num.real.vec.str.strung.co;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.matrix.grid.co_.conform.multi_.rowsEs1ColsEs_
{
	///
	///<summary>
	/// </summary>
	/// <seealso cref="nilnul.num.real.matrix.grid.co_.conform._MultiX"/>
	/// <see cref="real.vec.str.strung.co._Multi2matrixX"/>
	[Obsolete("in comparision with " + nameof(_Multi2matrixX) + ", this one is error-prone and too complex.")]
	public class _BlockwiseX
	{
		/// <summary>
		/// </summary>
		/// <param name="majors"></param>
		/// <param name="minors">
		/// 
		/// </param>
		/// <returns></returns>
		/// <seealso cref=""/>
		static public IEnumerable<IEnumerable<IEnumerable<IEnumerable<double>>>> _MultiAsGrid_vecsAssumeEquisize(
			IEnumerable<
				IEnumerable<
					IEnumerable<double>	//vec
				>   //submatrix
			>
			majors
			,
			IEnumerable<
				IEnumerable<
					IEnumerable<double> //vec
				>  //submatrix
			>
			minors
		)
		{
			return majors.Select(
				m =>
				minors.Select(
					b => real.vec.str.co._Multi2matrixX._Multi_vecsAssumeEquisize(m, b)
				)
			);


		}

		static public double[,] _MultiAsMatrix_vecsAssumeEquisize(
			IEnumerable<
				IEnumerable<
					IEnumerable<double>	//vec
				>   //submatrix
			>
			majors
			,
			IEnumerable<
				IEnumerable<
					IEnumerable<double> //vec
				>  //submatrix
			>
			minors
		)
		{
			return matrix.grid.to_._ToMatrixX._Matrix_assumeDwelt1gridBlockEachDwelt(
				_MultiAsGrid_vecsAssumeEquisize(majors,minors)
			);


		}




	}
}
