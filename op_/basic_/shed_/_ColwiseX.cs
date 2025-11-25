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
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	/// 

	static public class _ColwiseX
	{

		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="col"></param>
		/// <param name="unnil"></param>
		static public void _Shed_2unnil(ref Q[,] m, int col, Q unnil)
		{

			int h = m.GetLength(0);
			for (var r = 0; r < h; r++)
			{
				m[r, col] *= unnil;

			}
		}

		static public void _Shed_2unnil(ref Q[,] m, long col, Q unnil)
		{

			for (var r = 0l; r < m.GetLongLength(0); r++)
			{
				m[r,col] *= unnil;

			}
		}


		/// <summary>
		/// <see cref="num.real.matrix.row._PivotX"/>
		/// </summary>
		/// <param name="m"></param>
		/// <param name="col"></param>
		/// <param name="unnil"></param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2unnilUnish(ref Q[,] m, int col, Q unnil)
		{
			if (unnil == 1) { return; }

			_Shed_2unnil(ref m, col, unnil);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shed_2unnilUnish(ref Q[,] m, long col, Q unnil)
		{
			if (unnil == 1) { return; }

			_Shed_2unnil(ref m, col, unnil);
		}



	}
}
