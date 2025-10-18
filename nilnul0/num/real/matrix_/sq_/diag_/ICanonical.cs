using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.diag_
{
	/// <summary>
	/// also known as: <see cref="sq_.ICanonic"/>
	/// </summary>
	/// alias:
	///		unipotent
	///		unidiag
	///		EveryIsOne
	///		canonical
	///		identity
	///	
	/// vs:
	///		samediag
	///		flatdiagonal

	public interface ICanonical:sq_.IDiagonal
		,
		real.matrix_.diag_.plat_.IAllOnesAtDiag
	{
	}

}
