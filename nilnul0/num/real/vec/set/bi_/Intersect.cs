using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.set.bi_
{
	static public class _IntersectX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<IEnumerable<Q>> _Intersect_01isosize(
			IEnumerable<IEnumerable<Q>> vecs
			,
			IEnumerable<IEnumerable<Q>> vecsB
		) {
			return vecs.Intersect(
				vecsB
				,
				nilnul.num.real.vec._Eq_assumeIsosize.Unison
			);
		}
	}
}
