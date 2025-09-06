using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.grid_.uxp_
{
	/// <summary>
	/// 
	///	or 2*0:
	///		{
	///			[]
	///			[]
	///		}
	///	, the grid 1*0 can not recover matrix 2*0. we need a grid unvacant such as 1*1 to hold the original matrix.
	///	<see cref="nilnul.obj.matrix.grid_.IUxp"/>
	/// </summary>
	internal class IVacant
		:nilnul.obj.matrix_.IVacant
	{
	}
}
