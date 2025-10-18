using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.triag_.unidiag_
{
	/// <summary>
	/// diagonal but one row|col
	/// </summary>
	/// alias:
	///		slant,<see cref="real.matrix.op_.elem_.skews_.ISlant"/>
	public interface ISlant
		:
		triag_.IUnidiag
		,
		sq_.elem_.skews_.ISlant
	{
	}


}
