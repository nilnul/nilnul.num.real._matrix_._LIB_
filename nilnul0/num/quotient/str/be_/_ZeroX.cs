using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.str.be_
{
	/// <see cref="num.quotient.str.be_._IsZeroX"/>
	/// <summary>
	/// zero row;
	/// </summary>
	/// alias:
	///		zero
	///			,zerow
	static public class _ZeroX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(in IEnumerable<Q4> reals) {

			return reals.All(
				x=> x==0
			);
		}
	}


}
