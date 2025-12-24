using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.space.basis_
{
	/// <summary>
	/// the standard basis (also called natural basis or canonical basis) of a coordinate vector space (such as R^n) is the set of vector(<see cref="num.real.vec_.ICanonical"/>)s, each of whose components are all zero, except one that equals 1
	/// </summary>
	public interface IStandard:space.IBasis
	{
	}

}
