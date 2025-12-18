using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix_.sq_.shuffler.of_
{
	/// <summary>
	/// transform a <see cref="nilnul.sortie.IShuffle"/> into a <see cref="sq_.ish"/>
	/// </summary>
	static public class _OfShuffleX
	{
		static public Q4[,] _ToShuffler_0shuffle(
			params int[] shuffle
		) {
			var height = shuffle.Length;

			var o = num.real.matrix_.sq_._NilX.Generate8quotient(height);

			for (int i = 0; i < height; i++)
			{
				o[i, shuffle[i]] = 1;
			}
			return o;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] _ToShuffler_0shuffle(
			IEnumerable<int> shuffle
		) {
			return _ToShuffler_0shuffle(shuffle.ToArray());
		}

	


	}
}
