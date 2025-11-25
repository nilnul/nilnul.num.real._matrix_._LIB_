using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.triag_
{
	/// <summary>
	/// lower are all nils.
	/// </summary>
	/// alias:
	///		
	/// vs:
	///		<see cref="ILower"/>, whileas this is the supertype of <see cref="matrix_.IIndent"/>, so is preferred to <see cref="ILower"/>
	public interface IUpper:
		ITriangular
		,
		real.matrix_.trape_.IRight
	{
	}
}
