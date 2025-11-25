using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_.trape_
{
	/// <summary>
	/// only the upper part is non-zero; the diagonal can be 0 or non-zero;
	/// eg:
	///		{
	///			1,0,3,0,0;
	///			0,0,0,0,0;
	///			0,0,2,1,0;
	///		}
	/// </summary>
	/// <remarks>
	///  <see cref="IIndent"/>
	/// </remarks>
	/// alias:
	///		right, especially when the matrix is <see cref="num.real.matrix.be_.IUnEquilateral"/>
	public interface IUpper
	{
	}

}
