using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.row.be_
{
	
	static public class _UnialX
	{


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _IsUnial_1row(in Q[,] matrix,in int row)
		{
			return num.real.vec.be_._UnialX.Be(
				obj.matrix._RowsX.Row( matrix, row)
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
