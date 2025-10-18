using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.echelon_
{
	/// <summary>
	/// as it's invertible, hence along the diagonal are all 1s.
	/// </summary>
	public interface IInvertible
		:sq_.IEchelon
		,
		sq_.IInvertible
	{
	}


}
