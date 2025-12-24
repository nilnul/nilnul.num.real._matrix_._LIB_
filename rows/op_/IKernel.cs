using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.rows.op_
{
	/// <summary>
	///  for matrix A, 
	///		yA =0
	///		, where y is a combinator of the rows of A
	///	;
	///	
	///	eg:
	///		[
	///			1,0,0
	///			0,1,0
	///		]
	///		, the kernel is :
	///		(0,0)
	///	;
	///	
	///	eg:
	///		[
	///			1,1,0
	///			1,1,0
	///		]
	///		, the kernel is :
	///		(1,-1)
	///	;
	///	
	///	
	/// </summary>
	/// <remarks>
	/// <see cref="real.matrix.rows.ISpan"/>, <see cref="real.matrix.cols.ISpan"/>, <see cref="real.matrix.op_.IKernel"/>, and <see cref="real.matrix.op_.ICoKernel"/>  are the  four fundamental subspaces associated with the matrix A
	/// </remarks>
	/// alias:
	///		left null space
	///		<see cref="real.matrix.op_.ICoKernel"/>
	public interface IKernel
		:real.vec.str.op_.IKernel
	{
	}
}
