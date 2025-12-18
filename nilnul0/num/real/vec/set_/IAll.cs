using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.set_
{
	/// <summary>
	/// given <see cref="obj._vec_.IArity"/>,
	///		all the vecs of that arity.
	///	;
	///	eg:
	///		all the vecs in 3d space.
	///		all the vecs in 0d space, which is a singleton having the <see cref="num.real.vec_.IEmpo"/>
	/// </summary>
	public interface IAll
		:real.vec.ISet
		,
		ISubspace
	{
	}


}
