using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.matrix.co_.multible.multi_.byGrid_
{
	///
	///<summary>
	///partition each matrix.
	/// </summary>
	///alias:
	///	by grouping
	///	by compart
	public class _BySplitX
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
		static public IEnumerable<IEnumerable< double>> _Multi_assumeDweltPortioned(
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


			return _ByRows1colsX.  _Multi_vecsAssumeEquisize(
				majors.SelectMany(m=>m)
				,
				minors.SelectMany(m=>m)
			);

	
		}




	}
}
