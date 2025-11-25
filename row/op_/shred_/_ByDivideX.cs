using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.row.op_.shred_
{
	/// <see cref="real.matrix.row"/>
	/// <see cref="real.matrix.op_._indent.IShed"/>
	/// <see cref="real.matrix.op_._indent._GaussGramX._Shed_2divisorUnish(ref quotient_.DenomNonnil[,], int, quotient_.DenomNonnil)"/>
	/// <summary>
	/// 
	/// </summary>
	static public class _ByDivideX
	{


		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <param name="divisor"></param>
		static public void _Divide(ref Q[,] m, int row, Q divisor)
		{

			int w = m.GetLength(1);
			for (int i = 0; i < w; i++)
			{
				m[row, i] /= divisor;

			}
		}

		static public void _Divide(ref Q[,] m, long row, Q divisor)
		{

			long w = m.GetLongLength(1);
			for (int i = 0; i < w; i++)
			{
				m[row, i] /= divisor;

			}
		}

		static public void _Divide(ref double[,] m, int row, double divisor)
		{

			int w = m.GetLength(1);
			for (int i = 0; i < w; i++)
			{
				m[row, i] /= divisor;

			}
		}

		static public void _Divide(ref double[,] m, long row, double divisor)
		{

			long w = m.GetLongLength(1);
			for (int i = 0; i < w; i++)
			{
				m[row, i] /= divisor;

			}
		}



		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <param name="divisor"></param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Divide_2unish(ref Q[,] m, int row, Q divisor)
		{
			if (divisor == 1) { return; }

			_Divide(ref m, row, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Divide_2unish(ref Q[,] m, long row, Q divisor)
		{
			if (divisor == 1) { return; }

			_Divide(ref m, row, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Divide_2unish(ref double[,] m, int row, double divisor)
		{
			if (divisor == 1) { return; }

			_Divide(ref m, row, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Divide_2unish(ref double[,] m, long row, double divisor)
		{
			if (divisor == 1) { return; }

			_Divide(ref m, row, divisor);
		}



	}
}
