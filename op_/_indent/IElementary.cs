using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_._indent
{
	/// as we are now using matrix, hence this is defined as not only to operate once, but recursively multiple times, like done by an invertible matrix multiplication.
	/// 
	/// <summary>
	/// elementary transformation. on rows , or cols.
	/// multiplied by an invertible matrix from left(rowwise elementary), or from right(colwise elementary);
	/// this is in fact a nonregressive linear span in different representations.
	/// </summary>
	/// 
	/// <remarks>
	/// this is used to solve linear equations.
	/// <see cref="op_.rowspan_.basic_"/>
	/// or <see cref="op_.colly"/>
	/// </remarks>
	/// alias:
	///		basic
	///		rudimental
	///		fundamental
	///		elementary
	///		gaussian gram
	///		
	public interface IElementary:matrix.IOp
	{
	}
}
