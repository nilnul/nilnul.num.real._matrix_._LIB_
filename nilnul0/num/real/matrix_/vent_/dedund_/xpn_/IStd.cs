using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.dent_.echelon_.vent_.dedund_.xpn_
{
	/// pivot: <see cref="nilnul.num.real.vec.IPivot"/>
	/// <summary>
	/// 
	/// 
	/// eg:
	///		[
	///			1,1/2
	///			0,0
	///		]
	///	;
	///	
	/// for each pivot, the other cels in the column is 0.
	/// 
	///	eg:
	///		[
	///			1,2
	///			0,1
	///		]
	///		,can be further processed as:
	///			[
	///				1,0
	///				0,1
	///			]
	///		;
	///	eg:
	///			[
	///				1,0, 3
	///				0,1, 1
	///			]
	///	this requires colwise operation, hence <see cref="xpn_"/>. <see cref="op_.colwise_"/>, <see cref="real.matrix_.vent.op_.IStd"/>
	///		
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	internal class IStd
	{
	}


}
