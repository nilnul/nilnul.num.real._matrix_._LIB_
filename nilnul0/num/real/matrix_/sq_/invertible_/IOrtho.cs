using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.invertible_
{
	/// <summary>
	/// perpendicular to each other.
	/// (their dot product is 0).
	/// </summary>
	/// <remarks>
	///		not nil as this is <see cref="IInvertible"/>
	/// </remarks>
	///
	/// vs:
	///		perpend, which means the relation among two, while ortho means any pair.
	///		normal, wich can be related to a vect, or a surface
	/// 
	public interface IOrtho
		:sq_.IInvertible
	{
	}


}
