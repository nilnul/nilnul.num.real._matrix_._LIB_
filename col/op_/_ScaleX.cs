using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.col.op_
{
	/// <see cref="real.matrix.row"/>
	/// <summary>
	/// 
	/// </summary>
	static public class _ScaleX
	{


		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/> 
		/// </summary>
		/// <param name="m"></param>
		/// <param name="col"></param>
		/// <param name="divisor"></param>
		static public void _Scale_1col(ref double[,] m, int col, double divisor)
		{

			int height = m.GetLength(0);

			for (int r = 0; r < height; r++)
			{
				m[r,col] *= divisor;

			}
		}
		static public void _Scale_1col(ref Q[,] m, int col, Q divisor)
		{

			int high = m.GetLength(0);

			for (int r = 0; r < high; r++)
			{
				m[r,col] *= divisor;

			}
		}


		static public void _Scale_1col(ref Q[,] m, long col, Q divisor)
		{
			int high = m.GetLength(0);

			for (int r = 0; r < high; r++)
			{
				m[r,col] /= divisor;

			}

		}

		static public void _Scale_1col(ref double[,] m, long col, double divisor)
		{
			int high = m.GetLength(0);

			for (int h = 0; h < high; h++)
			{
				m[h,col] *= divisor;

			}

		}




		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="col"></param>
		/// <param name="divisor"></param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Scale_2unish(ref Q[,] m, int col, Q divisor)
		{
			if (divisor == 1) { return; }

			_Scale_1col(ref m, col, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Scale_2unish(ref Q[,] m, long col, Q divisor)
		{
			if (divisor == 1) { return; }

			_Scale_1col(ref m, col, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Scale_2unish(ref double[,] m, int col, double divisor)
		{
			if (divisor == 1) { return; }

			_Scale_1col(ref m, col, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Scale_2unish(ref double[,] m, long col, double divisor)
		{
			if (divisor == 1) { return; }

			_Scale_1col(ref m, col, divisor);
		}




	}
}
