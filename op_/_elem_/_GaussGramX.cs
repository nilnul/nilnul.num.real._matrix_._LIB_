using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_._indent
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		basic
	///		stepwise
	///		fundamental
	///		rudimental
	static public class _GaussGramX
	{

		///// <summary>
		///// the scale of the orther row is 1
		///// </summary>
		///// <param name="m"></param>
		///// <param name="augend">
		///// self
		///// </param>
		///// <param name="addend">
		///// other
		///// </param>
		//static public void _Slant_12row_3scale(ref double[,] m, long augend, long addend)
		//{
		//	for (long i = 0; i < m.GetLongLength(1); i++)
		//	{
		//		m[augend, i] += m[addend, i];
		//	}
		//}



		///// <summary>
		///// 
		///// </summary>
		///// <param name="m"></param>
		///// <param name="augend"></param>
		///// <param name="addend"></param>
		//static public void _Slant_12row_3scale(ref Q[,] m, long augend, long addend)
		//{
		//	for (long i = 0; i < m.GetLongLength(1); i++)
		//	{
		//		m[augend, i] += m[addend, i];
		//	}
		//}


		static public void _Skew_12row(ref double[,] m, int augend, int addend, double scale)
		{
			for (long i = 0; i < m.GetLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];
			}
		}

		static public void _Skew_12row(ref double[,] m, long augend, long addend, double scale)
		{
			for (long i = 0; i < m.GetLongLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Skew_12row_3nilish(ref double[,] m, int augend, int addend, double scale)
		{
			if (scale==0)
			{
				return;
			}
			_Skew_12row(ref m, augend, addend, scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Skew_12row_3nilish(ref double[,] m, long augend, long addend, double scale)
		{
			if (scale==0)
			{
				return;
			}
			_Skew_12row(ref m, augend, addend, scale);
		}

		static public void _Skew_12row(ref Q[,] m, int augend, int addend, Q scale)
		{
			for (long i = 0; i < m.GetLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];

			}
		}



		static public void _Skew_12row(ref Q[,] m, long augend, long addend, Q scale)
		{
			for (long i = 0; i < m.GetLongLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];

			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Skew_12row_3nilish(ref Q[,] m, int augend, int addend, Q scale)
		{
			if (scale==0)
			{
				return;
			}
			_Skew_12row(ref m, augend,addend,scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Skew_12row_3nilish(ref Q[,] m, long augend, long addend, Q scale)
		{
			if (scale==0)
			{
				return;
			}
			_Skew_12row(ref m, augend,addend,scale);
		}

		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <param name="divisor"></param>
		static public void _Shed(ref Q[,] m, int row, Q divisor)
		{

			for (int i = 0; i < m.GetLength(1); i++)
			{
				m[row, i] /= divisor;

			}
		}

		static public void _Shed(ref Q[,] m, long row, Q divisor)
		{

			for (int i = 0; i < m.GetLongLength(1); i++)
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
		static public void _Shed_2unish(ref Q[,] m, int row, Q divisor)
		{
			if (divisor == 1) { return; }

			_Shed(ref m, row, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2unish(ref Q[,] m, long row, Q divisor)
		{
			if (divisor == 1) { return; }

			_Shed(ref m, row, divisor);
		}


		static public void _Swap_2dif(ref Q[,] m, int i, int j)
		{
			for (var k = 0; k < m.GetLength(1); k++)
			{
				SwapX.Swap(ref m[i, k], ref m[j, k]);
			}

		}


		static public void _Swap_2dif(ref Q[,] m, long i, long j)
		{
			for (long k = 0; k < m.GetLongLength(1); k++)
			{
				SwapX.Swap(ref m[i, k], ref m[j, k]);
			}

		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Swap(ref Q[,] m, long i, long j)
		{
			if (i == j)
			{
				return;

			}
			_Swap_2dif(ref m, i, j);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Swap(ref Q[,] m, int i, int j)
		{
			if (i == j)
			{
				return;

			}
			_Swap_2dif(ref m, i, j);

		}

	}
}
