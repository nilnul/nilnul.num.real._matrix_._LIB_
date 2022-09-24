using nilnul.num.real.matrix.co_.multible.multi_;
using nilnul.num.real.vec.str.co;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec.str.strung.co
{
	///
	///<summary>
	///partition each matrix.
	/// </summary>
	///alias:
	///	by grouping
	///	by compart
	public class _Multi2matrixX
	{
		/// <summary>
		/// partition of vecs
		/// </summary>
		/// <param name="majors"></param>
		/// <param name="minors">
		/// size eq to that of <paramref name="majors"/>
		/// 
		/// </param>
		/// <returns></returns>
		/// <seealso cref=""/>
		static public IEnumerable<IEnumerable< double>> _Multi_vecsAssumeEquisize(
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

			return vec.str.co.cartesian.map_._InnerProductEsX._Multi_vecsAssumeEquisize(
				majors.SelectMany(m=>m)
				,
				minors.SelectMany(m=>m)
			);

		}

		static public  double[,] _MultiAsMatrix_vecsAssumeEquisize(
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

			return vec.str.co.cartesian.map_._InnerProductEsX._MultiAsMatrix_vecsAssumeEquisize(
				majors.SelectMany(m=>m)
				,
				minors.SelectMany(m=>m)
			);

		}



	}
}
