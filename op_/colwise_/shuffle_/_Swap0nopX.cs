using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.op_.colwise_.shuffle_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	/// 

	static public class _Swap0nopX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Swap0nop(ref Q[,] m, int i, int j)
		{
			if (i!=j)
			{
				matrix.op_.colwise_.basic_._SwapX._Swap_2dif(ref m, i, j);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Swap0nop(ref Q[,] m, long i, long j)
		{

			if (i!=j)
			{
				matrix.op_.colwise_.basic_._SwapX._Swap_2dif(ref m, i, j);
			}

		}
	}
}
