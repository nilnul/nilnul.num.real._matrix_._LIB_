using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.compart.co
{
	static public class _InnerProductX
	{
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
		static public double _InnerProduct_assumeComparts(
			IEnumerable<IEnumerable<double>> a
			,
			IEnumerable<IEnumerable<double>> b

		) {
			return _InnerProductEs_assumeComparts(a,b).Sum();
		}

	}
}
