using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vecs_
{
	/// <summary>
	/// each in the independent vecs is called a basis;
	/// </summary>
	/// alias:
	///		basis
	///			,it's the result of <see cref="vec.ISubSpace"/>
	public interface IIndependent
		:real.IVecs
	{
	}
}
