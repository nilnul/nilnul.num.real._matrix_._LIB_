using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.basic_.skew_.colwise_
{
	/// <summary>
	///  c[i] -= c[j]*x
	///  , where the two cols must be different to make the op unregressed;
	/// </summary>
	/// alias:
	/// 
	static public class _BySubtractX
	{
		static public void _Skew_12col(ref double[,] m, int augend, int addend, double scale)
		{
			var h = m.GetLength(0);
			for (var r = 0; r < h; r++)
			{
				m[r, augend ] -= scale * m[r, addend];
			}
		}

		static public void _Skew_12col(ref double[,] m, long augend, long addend, double scale)
		{
			var h = m.GetLongLength(0);
			for (var r = 0l; r < h; r++)
			{
				m[r, augend ] -= scale * m[r, addend];
			}
		}

		static public void _Skew_12col(ref Q[,] m, int augend, int addend, Q scale)
		{
			var h = m.GetLength(0);
			for (var r = 0; r < h; r++)
			{
				m[r, augend ] -= scale * m[r, addend];
			}

		}

		static public void _Skew_12col(ref Q[,] m, long augend, long addend, Q scale)
		{
			var h = m.GetLongLength(0);
			for (var r = 0l; r < h; r++)
			{
				m[r, augend ] -= scale * m[r, addend];
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Skew_12col_3nilish(ref double[,] m, int augend, int addend, double scale)
		{
			if (scale==0)
			{
				return;
			}
			_Skew_12col(ref m, augend, addend, scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Skew_12col_3nilish(ref double[,] m, long augend, long addend, double scale)
		{
			if (scale==0)
			{
				return;
			}
			_Skew_12col(ref m, augend, addend, scale);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <param name="augend"></param>
		/// <param name="addend">
		/// different row; cannot be the same row
		/// </param>
		/// <param name="scale"></param>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Skew_12col_3nilish(ref Q[,] m, int augend, int addend, Q scale)
		{
			if (scale==0)
			{
				return;
			}
			_Skew_12col(ref m, augend,addend,scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Skew_12col_3nilish(ref Q[,] m, long augend, long addend, Q scale)
		{
			if (scale==0)
			{
				return;
			}
			_Skew_12col(ref m, augend,addend,scale);
		}


	}
}
