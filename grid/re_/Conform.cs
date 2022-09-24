using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.grid.re_
{
	static public class _ConformX
	{
		static public bool Re(
			double[,][,] a
			,
			double[,][,] b
		) {


			return
				//nilnul.obj.matrix.re_._MultibleX.Re(a, b)
			//	&&
				obj.matrix._RowsX.Rows(a).All(
					r=> obj.matrix._ExtensionsX.Cols(b).All(
						c=>
						matrix.str.re_._ConformableX.Be(
							r,c
						)
					)
				);



		}
	}
}
