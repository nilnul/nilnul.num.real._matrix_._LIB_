using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.basic_
{
	/// <see cref="real.matrix.row.co_.unself.ISkew"/>
	/// merge by adding another row(cannot be the same row) to this row.
	/// 
	/// <summary>
	/// R0 -= a* R1
	///		,where a can be 0, but usually it's the pivot of R0, hence unnil. when a is 0, it's a noop.
	///		, where "-" makes the 'a' as the pivot of R0
	///	;	
	/// eg:
	///		[
	///			1,0,0
	///			0, 1,0
	///			0,k,1
	///		]
	///		,would be: row[2] -= k*row[1]
	/// </summary>
	/// 
	/// todo: get a matrix,B, for X
	///		[
	///			1,0,0
	///			0, 1,0
	///			0,k,1
	///		]
	///		, such that BX would make : row[2] -= k*row[1]
	///		, it seems it is:
	///		
	///		[
	///			1,0,0
	///			0, 1,0
	///			0,-k,1
	///		]
	///		hence 
	/// 
	///		[
	///			1,0,0
	///			0, 1,0
	///			0,-k,1
	///		]
	///		*
	///		[
	///			1,0,0
	///			0, 1,0
	///			0,k,1
	///		]
	///		=
	///		canonical
	/// 
	/// <remarks>
	///  this is linear combinate, where at least one coef is not nil (for two different rows).
	/// </remarks>
	/// 
	/// <see cref="num.real.matrix_"/>
	/// alias:
	///		skew
	///		slant
	///		scoop, like scale, swap
	///		slope
	///		slop
	///		slip
	///		slay
	///		slant
	///		<see cref="op_._indent.gauss_.ISkew"/>
	///		斜切
	///		
	///		
	/// use "-=", not "-", to eliminate ambiguity

	public interface ISkew:matrix.IOp
	{
	}


}
