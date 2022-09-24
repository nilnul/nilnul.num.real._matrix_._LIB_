using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// 1*1 matrix
	/// </summary>
	/// <remarks>
	/// vs:
	///		<see cref="IUnial"/> which might be not 1*1, and can be 2*2, 3*3, etc
	/// </remarks>
	/// alias:
	///		singulary
	///		primary
	///			followed by secondary, which means 2nd in rank
	///		
	public interface ISingulary
		:
		matrix_.ISquare
	{
	}
}
