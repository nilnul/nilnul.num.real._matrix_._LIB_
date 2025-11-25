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
	///	vs:
	///		std, which is <see cref="nilnul.num.real.str.be_"/>,<see cref="nilnul.num.real.str_.std"/>,<see cref="nilnul.num.real.vec.be_._IdealX"/>, <see cref="nilnul.num.real.vec_.std_"/>
	static public class _Paragon0nilX
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
