using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.vent.row_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///  for <see cref="matrix_.IVent"/>, all nil rows are at the bottom;
	/// </remarks>
	public interface INil:real.matrix.IRow
		,
		real.vec_.IZero
	{
	}


}
