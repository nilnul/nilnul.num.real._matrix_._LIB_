using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec.compart.str.co
{

	/// <summary>
	/// the result is:
	///		many (strung, strung)
	///			,grouped
	///	; 
	/// </summary>
	public class _CartesianProductX
	{
		/// <summary>
		/// this is better defined by <see cref="real.matrix.vec.co_.sommable._SomX"/>
		/// </summary>
		/// <param name="belt"></param>
		/// <param name="bunch"></param>
		/// <returns>
		///  grouped:
		///		(
		///			 IEnumerable :  (a, b0), (a,b1) ,
		///		)
		///		,
		///		(
		///			 IEnumerable :  (a1, b0), (a1,b1) ,
		///		)
		///		
		///
		/// </returns>
		static public IEnumerable<
			IEnumerable< (
				IEnumerable< IEnumerable< double>>
				,
				IEnumerable< IEnumerable< double>>
			)>
		> _CartesianProduct(
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
				bunch.Select( /// IEnumerable :  (a, b0), (a,b1) ,... ; maybe we shall use selectMany to flatten the group.
					c=> (r,c)
				)
			);
		}




	}
}
