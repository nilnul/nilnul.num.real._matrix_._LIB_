using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_
{
	/// <summary>
	/// rowise swap
	/// </summary>
	/// 
	static public class _ShuffleX
	{
		[Obsolete(nameof(real.matrix.op_.basic_.ISwap))]

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Shuffle_assumeValid(in double[,] m, in int r, in int r1) {

			nilnul.obj.matrix.op_.unary_ .shuffle_._RowwiseX._Act_assumeValid(in m,in r, in r1);
		}

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _New_assumeValid(in double[,] m, in int r, in int r1) {
			var cloned = real.matrix.op_.unary_._CloneX.Clone(m);

			nilnul.obj.matrix.op_.unary_ .shuffle_._RowwiseX._Act_assumeValid(in cloned,in r, in r1);
			return cloned;
		}

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int[,] _New_assumeValid(int[,] m, int r, int r1)
		{
			var cloned = real.matrix.op_.unary_._CloneX.Clone(m);

			nilnul.obj.matrix.op_.unary_ .shuffle_._RowwiseX._Act_assumeValid(in cloned,in r, in r1);
			return cloned;

		}
	}
}
