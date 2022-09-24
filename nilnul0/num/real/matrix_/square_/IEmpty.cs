using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// 0*0
	/// </summary>
	/// 
	public interface IEmpty
		:
		matrix_.ITrivia // where also includes: 0*1, 2*0, etc
		,
		ISquare
	{
	}
}
