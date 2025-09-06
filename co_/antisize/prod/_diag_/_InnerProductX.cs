using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.compart.co
{
	/// <summary>
	/// this is better defined by matrix multiplication.
	/// </summary>
	///
	[Obsolete("hard to understand, not well defined")]
	static public class _InnerProductX
	{
		/// <summary>
	/// the result of this is the diagonal of the product:matrix.
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public IEnumerable< double> _InnerProductEs_assumeComparts(
			IEnumerable<IEnumerable<double>> a
			,
			IEnumerable<IEnumerable<double>> b

		) {
			return a.Zip(
				b,
				(x,y) => num.real.str.co_.sameLen._InnerProductX._Eval(
					x
					,
					y
				)
			);
		}

		/// <summary>
		/// the trace
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public double _InnerProduct_assumeComparts(
			IEnumerable<IEnumerable<double>> a
			,
			IEnumerable<IEnumerable<double>> b

		) {
			return _InnerProductEs_assumeComparts(a,b).Sum();
		}

	}
}
