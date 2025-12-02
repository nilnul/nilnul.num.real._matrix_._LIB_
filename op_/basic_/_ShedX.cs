using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.basic_
{
	/// <summary>
	/// <see cref="matrix_.sq_.basic_.IShed"/> as a multiplier (dividing is complex and unassociative) means the shed is to scale one row.
	/// in align, this also means multiplication..
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// for nilable scale one row, <see cref="real.matrix.row.op_._ParagonizeX"/>, <see cref="real.matrix.row.op_._ShedX"/> 
	/// 

	static public class _ShedX
	{

		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <param name="amplifier"></param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2unnil(ref Q[,] m, int row, Q amplifier)
		{
			real.matrix.row.op_._ScaleX._Shred_1row(ref m, row,amplifier);
			//for (var i = 0; i < m.GetLength(1); i++)
			//{
			//	m[row, i] *= amplifier;
			//}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2unnil(ref Q[,] m, long row, Q amplifier)
		{
			real.matrix.row.op_._ScaleX._Shred_1row(ref m, row,amplifier);

			//for (var i = 0l; i < m.GetLongLength(1); i++)
			//{
			//	m[row, i] *= amplifier;

			//}
		}


		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <param name="unnil"></param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2unnilUnish(ref Q[,] m, int row, Q unnil)
		{
			real.matrix.row.op_._ScaleX._Shred_2unish(ref m, row,unnil);
			//if (unnil == 1) { return; }

			//_Shed_2unnil(ref m, row, unnil);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2unnilUnish(ref Q[,] m, long row, Q unnil)
		{
			real.matrix.row.op_._ScaleX._Shred_2unish(ref m, row,unnil);

			//if (unnil == 1) { return; }

			//_Shed_2unnil(ref m, row, unnil);
		}



	}
}
