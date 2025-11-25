using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_.dent_
{
	/// <summary>
	/// colwise echelon;
	/// <see cref="IRowwise"/> when transposed.
	/// ;
	/// lower triangle.
	/// eg:
	///		{
	///			1	,0	,0,0,0;
	///			1	,1	,0,0,0;
	///			0	,1	,0,0,0;
	///
	///	}
	/// </summary>
	/// vs:
	///		<see cref="matrix.be_.colwise_"/>
	///		<see cref="matrix.cols.be_."/>
	internal class IColwise:IIndent
	{
	}
}
