using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.rows
{
	/// <summary>
	/// a vec multiply the matrix from the left. That is:
	///		vM, where v is the coefficients as a row, and M is the matrix.
	/// </summary>
	/// <remarks>
	/// this forms a subspace (<see cref="real.vec.set.LinearSpan"/>)
	/// ; the canonical form is <see cref="matrix.op_.rowspan_.indent_.std_.IChimney"/>
	/// </remarks>
	/// <see cref="num.real.matrix."/>
	/// 
	/// alias:
	///		rows.span
	///		<see cref="real.vecs.IHull"/>
	///		ILinearCombinate
	///		rowspace
	///		rowspan
	///		
	///		
	///	vs:
	///		<see cref="matrix.cols.ILinearCombinate"/>
	///		<see cref="real.matrix.cols.ISpan"/>
	///		
    public interface ISpan:nilnul.num.real.vecs.IHull
    {
    }
}
