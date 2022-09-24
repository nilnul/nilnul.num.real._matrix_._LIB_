using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec_.tro.str.co.cartesian.map_
{
	///
	///<summary>
	/// use a concrete example to explain <see cref="vecs1vecs_"/>
	/// </summary>
	///
	public class _InnerProductEsX
	{


		/// <summary>
		/// return a str ofvec, the length is the size of the major.
		/// </summary>
		/// <param name="major"></param>
		/// <param name="minor"></param>
		/// <returns>
		/// size is the same as that of major.
		/// component is uniformly of the minor size.
		/// </returns>
		/// we usually write down the minor as colwise. but that's a convention, not covenance.
		static public IEnumerable<IEnumerable<double>> Multi(
			IEnumerable<nilnul.num.real.vec_.Tro4dbl> major
			,
			IEnumerable<nilnul.num.real.vec_.Tro4dbl> minor
		)
		{
			return major.Select(
				x =>vec_.tro.str. map_._InnerProductX.MapByInnerProduct(minor,x)
			)
			#region MyRegion
			/// the component in the result is not tro anymore. its length depends on the minor.
				//	.Select(t=> new nilnul.num.real.vec_.Tro4dbl(
				//	 nilnul.obj.vec_._TroX._ValTup_assumeCo(t) 
				//	)
				//)
			#endregion
			;
		}


	}
}
