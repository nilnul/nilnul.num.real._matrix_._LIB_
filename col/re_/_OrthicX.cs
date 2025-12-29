using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.col.re_
{
	
	static public class _OrthicX
	{


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _IsOrthic_0col_1other(in Q[,] matrix,in int col,in int other)
		{
			return num.real.vec.re_._OrthicX.Re(
				obj.matrix._ColsX.Col( matrix, col)
				,
				obj.matrix._ColsX.Col( matrix, other)
			);
		}

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		//static public bool _IsOrthic_0row_1other(in Q[,] matrix,in long width,in long row)
		//{
		//	return num.real.vec.re_._OrthicX.Re(
		//		obj.matrix._RowsX.Row( matrix, width)
		//		,
		//		obj.matrix._RowsX.Row( matrix, row)
		//	);
		//}


	}
}
