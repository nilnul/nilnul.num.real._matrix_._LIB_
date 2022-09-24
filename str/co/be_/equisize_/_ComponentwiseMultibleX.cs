using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.str.co.be_.equisize_
{
	static public class _ComponentwiseMultibleX
	{
		static public bool Be<T>(IEnumerable<T[,]> row, IEnumerable<T[,]> col) {
			return row
				.Select(
					x => x.GetLength(1)
				)
				.SequenceEqual(
					col
					.Select(y => y.GetLength(0))
				
				) 
;
		}

	}
}
