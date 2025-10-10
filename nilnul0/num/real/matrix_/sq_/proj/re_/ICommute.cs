using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.sym_.idem_.proj.re_
{
	/// <summary>
	/// in general PQ != QP, where P,Q are <see cref="IProjection"/>;
	/// but when :
	///		P^T Q =0, that is P and Q are orthic,
	///		or
	///		P is subspace of Q
	///	, then PQ are commute.
	/// </summary>
	/// <remarks>
	/// non overlapping part must be orthic;
	/// </remarks>
	public interface ICommute
		:
		proj.IRe
	{
	}


}
