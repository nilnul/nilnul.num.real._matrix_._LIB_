using nilnul.num.quotient.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.grid_.plaid_.diag
{
	static public class _DeterminantX
	{
	
		static public Q4 _Determinant_1widths( Q4[,] m, params int[] widths ) {
			var accumulated = 0;
			return widths.Select(
				w =>
				{
					var rows = Enumerable.Range(accumulated, w).ToArray();
					accumulated +=w;
					return real.matrix_.sq._determ_.by_._BySubmatrixX._Determinant_0sq_1rows_2cols(
						m, rows, rows
					
					);
				}
			)._Product_0str();
		
		}
	}
}
