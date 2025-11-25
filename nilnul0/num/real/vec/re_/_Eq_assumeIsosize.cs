using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec
{
	public class _Eq_assumeIsosize
		: IEqualityComparer<IEnumerable<Q>>
	{
		public bool Equals(IEnumerator<Q> x, IEnumerator<Q> y)
		{
			while (x.MoveNext()) {
				y.MoveNext();
				if (x.Current == y.Current)
				{
					continue;
				}
				return false;
			}
			return true;

		}
		/// <summary>
		/// assume equisize
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(IEnumerable<Q> x, IEnumerable<Q> y)
		{
			return Equals(x.GetEnumerator(),y.GetEnumerator());

		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetHashCode(IEnumerable<Q> obj)
		{
			return 0;
			///throw new NotImplementedException();
		}


		static public _Eq_assumeIsosize Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<_Eq_assumeIsosize>.Unison;
			}
		}

	}
}
