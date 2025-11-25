using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.row.op_
{
	/// <summary>
	/// <see cref="matrix_.sq_.diag_.IShred"/> as a multiplier (dividing is complex and unassociative) means the shred is to scale one row by 0 or not.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// 

	static public class _ShredX
	{

		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <param name="amplifier"></param>
		static public void _Shred_1row(ref Q[,] m, int row, Q amplifier)
		{
			int w = m.GetLength(1);
			for (var i = 0; i < w; i++)
			{
				m[row, i] *= amplifier;
			}
		}

		static public void _Shred_1row(ref Q[,] m, long row, Q amplifier)
		{

			long w = m.GetLongLength(1);
			for (var i = 0l; i < w; i++)
			{
				m[row, i] *= amplifier;

			}
		}


		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <param name="unish"></param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shred_2unish(ref Q[,] m, int row, Q unish)
		{
			if (unish == 1) { return; }

			_Shred_1row(ref m, row, unish);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shred_2unish(ref Q[,] m, long row, Q unnil)
		{
			if (unnil == 1) { return; }

			_Shred_1row(ref m, row, unnil);
		}



	}
}
