using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.rowspan_.indent_.std_
{
	/// pivot: <see cref="nilnul.num.real.vec.IPivot"/>
	/// <summary>
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
	///				0,0, 0
	///			]
	///		
	/// </summary>
	/// <remarks>
	/// <see cref="rowspan_.IIndent"/> is gotten by forward elimination, while this is gotten by backward substitution.
	/// </remarks>
	/// alias:
	///		reduced row echelon
	///		Gauss–Jordan elimination
	internal class ICanonical
	{
	}


}
