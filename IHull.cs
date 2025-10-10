using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix
{


	///<see cref="nilnul.num.real.matrix.rows.ILinearCombinate"/>
	/// <summary>
	/// <see cref="real.matrix.op_.rowspan_.indent_.std_.ICanonical"/>, but any nil rows are dropped.
	/// by default the span of matrix means the span of rows, not cols.
	/// </summary>
	/// <remarks>
	/// this may end at a vacant matrix, sized 0* n. (this justifies the meaningfulness of vacant matrix.)
	///; the canonical form is <see cref="real.matrix_.ICanonical"/>
	/// </remarks>
	/// alias:
	///		rowspan
	///		<see cref="matrix.op_.IRowSpan"/>
	///		span
	///		row space;
	///		hull, vs null<see cref="real.matrix.op_.IKernel"/>
	///	vs:
	///		<see cref="to_.IKernel"/>
	///		<see cref="matrix.op_.IKernel"/>
	///		space, which is full while this is subspace.
	public interface IHull
	{
	}
}
