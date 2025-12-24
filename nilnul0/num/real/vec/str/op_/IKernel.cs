using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.str.op_
{
	/// <see cref="num.real.matrix.cols.op_"/>
	/// <summary>
	/// the kernel is subspace of another arity;
	/// its rank + 
	/// 
	/// <see cref="vec.str.surrogate_._combo.ICombinator"/> that results as 0.
	/// so the arity of each combinator is the count of <see cref="vec.IStr"/>.
	/// ;
	/// eg:
	///		(1,0,0), (0,1,0)
	///			, the kernel is (0,0), a 2d point.
	///		(1,0,0),(1,0,0)
	///			,the kernel is (1,-1), a 2d line.
	///		(1,0,0),(0,1,0), (1,1,0)
	///			=> (1,1,-1), a 3d line.
	///		(1,0,0),(0,1,0), (1,1,0),(1,1,0)
	///			=> (1,1,-1,0), (1,1,0,-1)  a 4d plane
	/// ;
	/// hence, the kernel can be at least a (0,0,..0) point;
	/// 
	/// 
	/// 
	/// </summary>
	/// <remarks>
	/// same as <see cref="num.real.matrix.cols.op_.IKernel"/>
	/// </remarks>
	public interface IKernel
	{
	}
}
