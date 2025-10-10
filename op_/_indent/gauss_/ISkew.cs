using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_._indent.gauss_
{
	/// <see cref="real.matrix.row.co_.unself.ISkew"/>
	/// <summary>
	/// merge by adding another row(cannot be the same row) to this row.
	/// for row:
	///		A
	///		A = A + xB
	///		,where x can be 0.
	///		, a skew;
	///		
	/// eg:
	///		[
	///			1,0,0
	///			0, 1,0
	///			0,k,1
	///		]
	///		,would be: row[2] += k*row[1]
	/// </summary>
	/// alias:
	///		skew
	///		slant
	///		scoop, like scale, swap
	///		slope
	///		slop
	///		slip
	///		slant

	public interface ISkew:matrix.IOp
	{
	}


}
