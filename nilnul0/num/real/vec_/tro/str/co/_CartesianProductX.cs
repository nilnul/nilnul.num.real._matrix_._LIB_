using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec_.tro.str.co
{
	///
	///<summary>
	/// 
	/// </summary>
	///
	public class _CartesianProductX
	{

		static public IEnumerable<
			IEnumerable<(nilnul.num.real.vec_.Tro4dbl, nilnul.num.real.vec_.Tro4dbl)>
		> Multi(
			IEnumerable<nilnul.num.real.vec_.Tro4dbl> major
			,
			IEnumerable<nilnul.num.real.vec_.Tro4dbl> minor
		)
		{
			return major.Select(
				x => minor.Select(y=>(x,y))
			);
		}


	}
}
