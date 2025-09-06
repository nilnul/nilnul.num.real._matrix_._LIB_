using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.collective.be_
{
	/// <summary>
	/// given dimensions,
	/// 0 is in it.
	/// if x is in it, then cx is in it, where x is a scalar;
	/// if x,y is in it, then x+y is in it.
	/// </summary>
	public interface ISubSpace:nilnul.num.real.vec.collective.IBe
	{
	}
}
