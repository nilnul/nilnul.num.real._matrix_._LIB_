using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.str_.started_.isosize
{
	static public class _SumX
	{
		static public void _Absorb_1isosize(Q[,] a, IEnumerator<Q[,]> str)
		{
			while (str.MoveNext())
			{
				nilnul.num.real.matrix.bi_._AddX._Augment_1equisize(a, str.Current);
			}
		}

		static public Q[,] _Sum_1isosize(Q[,] a, IEnumerator<Q[,]> str)
		{
			var r = a.Clone() as Q[,];
			_Absorb_1isosize(r, str);
			return r;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void _Absorb_1isosize(Q[,] a, IEnumerable<Q[,]> str)
		{
			_Absorb_1isosize(a, str.GetEnumerator());

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Sum_1isosize(Q[,] a, IEnumerable<Q[,]> str)
		{
			return _Sum_1isosize(a, str.GetEnumerator());

		}


		static public Q[,] _Sum_0startedIsosize(IEnumerator<Q[,]> str)
		{
			str.MoveNext();
			return _Sum_1isosize(
					str.Current
					,
					str
			);
		}



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Sum_0startedIsosize(IEnumerable<Q[,]> str)
		{
			return _Sum_0startedIsosize(str.GetEnumerator());

		}


	}
}
