using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_
{
	/// used in complex matrix. but also applicable to real matrix.
	/// 
	///
	/// <summary>
	/// if U Ut = Ut U =I
	/// ,where Ut is the transpose.
	/// </summary>
	/// <remarks>
	/// vs:
	///		<see cref="ISingulary"/>
	///		<see cref="IUnial"/> 
	/// </remarks>
	///
	//[Obsolete("reserved for complex matrix")]
	public interface IUnitary
		:
		matrix_.ISquare
	{
	}
}
