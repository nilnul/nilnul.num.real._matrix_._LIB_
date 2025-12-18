using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.op_.colwise_.basic_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	/// 

	static public class _SwapX
	{

		static public void _Swap_2dif(ref Q[,] m, int i, int j)
		{

			int h = m.GetLength(0);
			for (var r = 0; r < h; r++)
			{
				SwapX.Swap(ref m[ r,i], ref m[r,j]);
			}

		}

		static public void _Swap_2dif(ref Q[,] m, long i, long j)
		{

			var h = m.GetLongLength(0);
			for (var r = 0; r < h; r++)
			{
				SwapX.Swap(ref m[ r,i], ref m[r,j]);
			}

		}
			



	}
}
