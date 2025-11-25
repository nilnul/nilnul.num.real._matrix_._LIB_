using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.str.be_
{
	/// <summary>
	/// zero row;
	/// </summary>
	/// alias:
	///		zero
	///			,zerow
	static public class _ZeroX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(IEnumerable<double> reals) {
			return reals.All(
				x=> x==0
			);
		}

	}


}
