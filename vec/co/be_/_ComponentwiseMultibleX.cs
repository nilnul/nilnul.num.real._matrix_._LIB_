using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.vec.co.be_
{
	static public class _ComponentwiseMultibleX
	{
		static public bool _Be_assumeEquisize<T>(IEnumerable<T[,]> a, IEnumerable<T[,]> b) {
			return a.Zip(
				b
				,
				(x,y) => obj.matrix.re_._MultibleX.Re(x,y)
			).All(
				x=> x
			);
		}
		static public bool Be<T>(IEnumerable<T[,]> row, IEnumerable<T[,]> col) {
			return str.co.be_.equisize_._ComponentwiseMultibleX.Be(row,col);
		}

	}
}
