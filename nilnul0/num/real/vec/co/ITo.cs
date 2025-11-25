using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.co
{
	/// <summary>
	/// real.vec.co => real
	/// </summary>
	public interface ITo
		:
		obj.ITo1<real.vec.ICo>
	{
	}
	public interface ITo<T>
		:
		ITo,
		obj.ITo<real.vec.ICo,T>
	{
	}


}
