using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.vec.co_
{
	/// <summary>
	/// componentwise <see cref="matrix.co_.IMultible"/>;
	///
	/// this doesnot gurarantee that the row is equihigh, or the col is equiwide. that means, the result is not necessarily plusable.
	/// </summary>
	/// alias:
	///		propagatable
	///		multible, which implies the result is also a vec
	///	
	///		sociable
	///			,not good.
	public interface IMultible8pairwise:vec.ICo
	{
	}
}
