using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.op_.basic_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	/// 

	[Obsolete(nameof(obj.matrix.op_._SwapX))]
	static public class _SwapX
	{

		static public void _Swap_2dif(ref Q[,] m, int i, int j)
		{

			for (var k = 0; k < m.GetLength(1); k++)
			{
				SwapX.Swap(ref m[i, k], ref m[j, k]);
			}

		}


		static public void _Swap_2dif(ref Q[,] m, long i, long j)
		{
			for (var k = 0l; k < m.GetLongLength(1); k++)
			{
				SwapX.Swap(ref m[i, k], ref m[j, k]);
			}

		}



	}
}
