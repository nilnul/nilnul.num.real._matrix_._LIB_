using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix
{


	///<see cref="nilnul.num.real.matrix.rows.IHull"/>
	/// <summary>
	/// <see cref="real.matrix.op_.rowspan_.indent_.std_.IChimney"/>, but any nil rows are dropped.
	/// by default the span of matrix means the span of rows, not cols.
	/// </summary>
	/// <remarks>
	/// this may end at a vacant matrix, sized 0* n. (this justifies the meaningfulness of vacant matrix.)
	///; the canonical form is <see cref="real.matrix_.ICanonical"/>
	/// </remarks>
	/// alias:
	///		rowspan
	///		<see cref="matrix.op_.IRowSpan"/>
	///		
	///		span
	///			,where you can reach taking the rows as steps/moves
	///			, the space spanned by the rows.
	///		row space;
	///		hull, vs null<see cref="real.matrix.op_.IKernel"/>
	///		<see cref="nilnul.num.real.vecs.IHull"/> is deferred to this, as this is unplural form, and a matrix is an elegant way to present <see cref="nilnul.num.real.vec.IStr"/>s.
	///	vs:
	///		<see cref="to_.IKernel"/>
	///		<see cref="matrix.op_.IKernel"/>
	///		space, which is full while this is subspace.
	///		husk, which is <see cref="cols.IHull"/>
	///		
	public interface IHull:matrix.rows.IHull, real.vecs.IHull
	{
	}
}
