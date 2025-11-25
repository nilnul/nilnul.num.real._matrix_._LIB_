using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnulnum.real.matrix_.sq_.antidiag
{
	static public class _DetermX
	{
		static public Q Determinant(IEnumerable<Q> antidiag) {

			int w = antidiag.Count();

			return ( w*(w-1) )%2==0 ? antidiag.Aggregate(Q.One,(a,c) =>a*c) : -antidiag.Aggregate(Q.One, (a, c) => a*c);
		}
	}
}
