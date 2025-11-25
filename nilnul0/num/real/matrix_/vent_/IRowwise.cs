using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.vent_
{
	/// <summary>
	/// there might be some redundant nil rows.
	/// eg:
	///		[	1,0,0, 0,0;
	///			0,1,0, 0, 0;
	///		]
	///		
	/// eg:
	///		[	1,0,0, 0,0;
	///			0,1,0, 0, 0;
	///			0,0,0,0,0 
	///		]
	/// 
	/// eg:
	///		[	1,0,0, 0,0;
	///			0,1,0, 1, 0;
	///			0,0,0,0,0 
	///		]
	///
	/// exclude:
	///		[	1,0,0
	///			0,1,0
	///			0,0,0
	///			0,1,0
	///			0,0,0
	///		], which is <see cref="IColwise"/>
	/// 
	/// </summary>
	public interface IRowwise
	{
	}

}
