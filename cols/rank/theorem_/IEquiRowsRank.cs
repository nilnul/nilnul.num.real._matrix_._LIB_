using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.cols.rank.theorem_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// proof:
	///		<see cref="num.real.matrix.op_.IStd"/>, where each matrix can be converted to a std matrix, conserving  its row rank and col rank. And the resulted has row rank and col rank equally;
	///		
	///	proof:
	///		the kernel of matrix are the rows span perpendicular to the rows span.
	///		each vector in kernel can act as the coefs of the columns to make them combinated as 0;
	///		meanwhile we know the combinators, per <see cref="num.real.matrix.op_._kernel_.by_._ByVentX"/>, is the arity - rows.rank. Each column of the free/nonbase variable's column can be expressed by the combination of the basis variables's columns. Hence the column rank is also arity-(arity-rows.rank) 
	///		
	/// proof:
	///		the rows rank = <see cref="num.real.matrix_.IStandard"/>'s rows rank.
	///		the cols rank will not change by rowwise invertible transformation, as that will not change the combinators. 
	/// </remarks>
	/// 
	internal class IEquiRowsRank
	{
	}
}
