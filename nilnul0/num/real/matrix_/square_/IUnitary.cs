using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// if U U* = U*U =C
	/// reserved for complex matrix
	/// </summary>
	/// <remarks>
	/// vs:
	///		<see cref="ISingulary"/>
	///		<see cref="IUnial"/> 
	/// </remarks>
	public interface IUnitary
		:
		matrix_.ISquare
	{
	}
}
