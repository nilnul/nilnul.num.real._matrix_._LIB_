using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.basic_.shed_
{
	/// <summary>
	/// <see cref="matrix_.sq_.basic_.IShed"/> as a multiplier (dividing is complex and unassociative) means the shed is to scale one row.
	/// But for <see cref="matrix.IOp"/>, we can explicitly operate it as division.
	/// </summary>
	/// <remarks>
	/// this is the inverse matrix of <see cref="matrix_.sq_.basic_.IShed"/>
	/// </remarks>
	/// alias:
	/// 

	static public class _ByDivideX
	{

		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <param name="divisor"></param>
		/// 

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2divisor(ref Q[,] m, int row, Q divisor)
		{
			nilnul.num.real.matrix.row.op_.shred_._ByDivideX._Divide(ref m, row, divisor);

			//for (var c = 0; c < m.GetLength(1); c++)
			//{
			//	m[row, c] /= divisor;

			//}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2divisor(ref Q[,] m, long row, Q divisor)
		{
			nilnul.num.real.matrix.row.op_.shred_._ByDivideX._Divide(ref m, row, divisor);

			//for (var c = 0l; c < m.GetLongLength(1); c++)
			//{
			//	m[row, c] /= divisor;

			//}
		}


		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <param name="divisor"></param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2divisorUnish(ref Q[,] m, int row, Q divisor)
		{
			nilnul.num.real.matrix.row.op_.shred_._ByDivideX._Divide_2unish(ref m, row, divisor);
			//if (divisor == 1) { return; }

			//_Shed_2divisor(ref m, row, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2divisorUnish(ref Q[,] m, long row, Q divisor)
		{
			nilnul.num.real.matrix.row.op_.shred_._ByDivideX._Divide_2unish(ref m, row, divisor);
			//if (divisor == 1) { return; }

			//_Shed_2divisor(ref m, row, divisor);
		}



	}
}
