using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec.compart.str.co
{
	
	public class _CartesianProductX
	{
		
		static public IEnumerable<
			IEnumerable< (
				IEnumerable<
				IEnumerable< double>
					>,
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
				bunch.Select(
					c=> (r,c)
				)
			);
		}




	}
}
