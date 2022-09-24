using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.sym_.definite_
{
	/// <summary>
	/// if the <see cref="ISymmetry"/> is neither <see cref="INonneg"/>, nore <see cref="INonpos"/>
	/// </summary>
	public interface IIndefinite
		:ISymmetry
	{
	}
}
