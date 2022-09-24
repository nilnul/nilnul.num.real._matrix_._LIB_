using nilnul.num.real.vec.compart.str.co;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec.str.co.cartesian.map_.innerProdEs_
{
	///
	///<summary>
	///partition each matrix.
	/// </summary>
	///alias:
	///	by grouping
	public class _PartitionVecX
	{


		///  we are dealing with matrix that is possiblly nonsquare.
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_major_dweltVecDwelt"></param>
		/// <param name="_minor_dweltVecDwelt"></param>
		/// <param name="_portions_eachPos_totalMatch">
		/// a partition of the vec/component.
		/// here we don't allow the partition of the other dimension
		/// </param>
		/// <returns></returns>
		/// <seealso cref="nilnul.num.real.matrix.vec.co_.conform._Belt1bunchX"/>
		static public IEnumerable< IEnumerable< double>> _Multi_vecAssumeSameSize(
			IEnumerable<IEnumerable<double>> _major_dweltVecDwelt
			,
			IEnumerable<IEnumerable<double>> _minor_dweltVecDwelt
			,
			int[] _portions_eachPos_totalMatch
		)
		{
			return compart.str.co.cartesian.map_._InnerProductEsX._Multi_assumeDwelt1CompartsSamePortioned(
				_major_dweltVecDwelt.Select(
					v=> nilnul.obj.str.split_._ProportionsX._Proportions_sizeAssumeNonneg1TotalLeSeq(v, _portions_eachPos_totalMatch)

				)
				,
				_minor_dweltVecDwelt.Select(
					v=>
				nilnul.obj.str.split_._ProportionsX._Proportions_sizeAssumeNonneg1TotalLeSeq(
					v, _portions_eachPos_totalMatch
					)
				)
			);

		
		}



	}
}
