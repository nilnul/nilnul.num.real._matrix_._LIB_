using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.basic_.shed_.colwise_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	/// 

	static public class _ByDivideX
	{

		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="col"></param>
		/// <param name="divisor"></param>
		static public void _Shed_2divisor(ref Q[,] m, int col, Q divisor)
		{
			//if (divisor==1) return;
			for (var r = 0; r < m.GetLength(0); r++)
			{
				m[r, col] /= divisor;

			}
		}

		static public void _Shed_2divisor(ref Q[,] m, long col, Q divisor)
		{
			//if (divisor==1) return;

			for (var r = 0l; r < m.GetLongLength(0); r++)
			{
				m[r,col] /= divisor;

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
		static public void _Shed_2divisorUnish(ref Q[,] m, int col, Q divisor)
		{
			if (divisor == 1) { return; }

			_Shed_2divisor(ref m, col, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2divisorUnish(ref Q[,] m, long col, Q divisor)
		{
			if (divisor == 1) { return; }

			_Shed_2divisor(ref m, col, divisor);
		}



	}
}
