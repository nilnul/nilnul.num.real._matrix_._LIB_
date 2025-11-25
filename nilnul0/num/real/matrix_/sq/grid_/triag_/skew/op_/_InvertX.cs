using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.grid_.triag_.skew.op_
{
	/// <see cref="real.matrix_.sq_.triag_."/>
	/// <summary>
	/// <see cref="real.matrix_.sq_.basic_.ISkew"/>
	/// <see cref="real.matrix_.sq_.basic_.skew.op_._InvertX"/>
	/// </summary>
	static public class _InvertX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <param name="_skewGrid">
		///  the <see cref="sq_.basic_.ISkew"/>
		/// </param>
		/// <param name="row">
		///  the row of the cel which is used to scale the other row/col
		/// </param>
		/// <param name="col">
		/// the col of the cel which is used to scale the other row/col
		/// </param>
		/// 
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Invert_0gridSkew_1rows_2cols(ref Q[,] _skewGrid, (int start, int until) rows, (int start, int until) cols)
		{
			for (int i = rows.start; i< rows.until; i++)
			{
				for (int j = cols.start; j< cols.until; j++)
				{
					_skewGrid[i, j] = -_skewGrid[i, j];
				}
			}
		}


		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Invert_0gridSkew_1rows_2cols( Q[,] _skewGrid, (int start, int until) rows, (int start, int until) cols)
		{
			var cloned = (Q[,] )_skewGrid.Clone();
			_Invert_0gridSkew_1rows_2cols(ref cloned,rows,cols);
			return cloned;
		}

	}
}
