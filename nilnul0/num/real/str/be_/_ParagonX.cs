using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.be_
{
	/// <summary>
	/// it's <see cref="_ZeroX"/> or the pivotValue is 1.
	/// </summary>
	/// alias:
	///		paragon
	///			,para means best is tried
	///		parapivot
	static public class _ParagonX
	{
		/// <summary>
		/// the pivot is 1
		/// </summary>
		/// <returns></returns>
		static public bool Be(
			IEnumerable<double> reals	
		) {
			var x = reals.SkipWhile(x => x ==0).Take(1);
			if (x.Any()) {
				return x.First() ==1;
			}
			return true;

		}
	}


}
