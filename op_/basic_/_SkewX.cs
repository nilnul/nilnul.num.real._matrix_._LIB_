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
	///  r[i] += r[j]*x
	///  , where we use '+', not '-', in align with <see cref="matrix_.sq_.basic_.ISkew"/> where the cel val is interpreted as '+'
	///  ;
	///  for -, we can not use <see cref="matrix_.sq_.basic_.ISkew"/> where it's a matrix for multiplication (division is complex, unassociative), but we can use <see cref="matrix.IOp"/>, where we can explicitly name the input parameter as subtractor:<see cref="op_.basic_.skew_.IBySubtract"/>.
	///  ; note the two rows must be different to make the op unregressed;
	/// </summary>
	/// alias:
	/// 
	static public class _SkewX
	{

		static public void _Skew_12row(ref double[,] m, int augend, int addend, double scale)
		{
			for (var i = 0; i < m.GetLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];
			}
		}

		static public void _Skew_12row(ref double[,] m, long augend, long addend, double scale)
		{
			for (var i = 0l; i < m.GetLongLength(1); i++)
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
			for (var i = 0; i < m.GetLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];

			}
		}

		static public void _Skew_12row(ref Q[,] m, long augend, long addend, Q scale)
		{
			for (var i = 0l; i < m.GetLongLength(1); i++)
			{
				m[augend, i] += scale * m[addend, i];
			}
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


	}
}
