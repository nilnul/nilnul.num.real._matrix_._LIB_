using nilnul.num.real.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.op_
{
	/// <see cref="nilnul.num.real.vec_.unnil.op_._StandardizeX"/>
	/// <see cref="nilnul.num.real.str.be_._Paragon0nilX"/>
	/// the result is <see cref="nilnul.num.real.vec_.ICanonical"/>
	/// <summary>
	/// make the pivot (if there is one) to be 1.
	/// </summary>
	/// <remarks>
	///  this is favored over <see cref="real.vec_.unnil.op_._UnializeX"/> in that:
	///		,this involves no radicand, thus is closure with respect to quotient;
	/// </remarks>
	/// alias:
	///		paragon
	///			,like pivot
	///		epitome
	///		flagpole
	static public class _ParagonX
	{
		static public IEnumerable<Q> Paragon(
				ref IEnumerable<Q> vec
		) {

			var p = vec.PivotValue();
			if (p==0)
			{
				return vec;
			}

			return vec.Select(
				x=> x /p
			);
		}
		static public void Paragon(
				ref Q[] vec
		) {

			var p = vec.PivotValue();
			if (p==0)
			{
				return;
			}

			for (int i = 0; i < vec.Length; i++)
			{
				vec[i]/=p;
			}
		}


	}
}
