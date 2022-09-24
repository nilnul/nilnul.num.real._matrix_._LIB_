using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec_.tro.str.map_
{
	///
	///<summary>
	/// use a concrete example to explain <see cref="vecs1vecs_"/>
	/// </summary>
	///
	static public class _InnerProductX
	{

		/// <summary>
		/// the returned is a vec, with minor.length as arity.
		/// </summary>
		/// <param name="major"></param>
		/// <param name="minor"></param>
		/// <returns></returns>
		static public IEnumerable<double> MapByInnerProduct(
			this
			IEnumerable<nilnul.num.real.vec_.Tro4dbl> minor
			,
			nilnul.num.real.vec_.Tro4dbl major
		)
		{
			return			 minor.Select(
					y => num.real.str.co_.sameLen._InnerProductX._Eval(major, y)
				)
			
		
			;
		}

		static public IEnumerable<double> MapByInnerProduct(
			nilnul.num.real.vec_.Tro4dbl major
			,
			IEnumerable<nilnul.num.real.vec_.Tro4dbl> minor
		)
		{
			return			MapByInnerProduct(minor,major);
		}


	


	}
}
