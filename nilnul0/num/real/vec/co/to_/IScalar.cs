using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.co.to_
{
	/// <summary>
	/// real.vec.co => real
	/// </summary>
	/// <see cref="num.vec.tup.to_.IMultilinearMap"/>
	/// alias:
	///		real
	///		scalar, which means unstructured, but is ambiguous as even real is structured, and sometimes we just take complex number, a 'co' as the element.
	public interface IScalar
		:real.vec.co.ITo<num.IReal>
	{
	}
}
