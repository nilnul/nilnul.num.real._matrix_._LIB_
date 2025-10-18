using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.triag_.upper_
{
	/// <summary>
	/// it's invertible
	/// </summary>
	public interface IDiagonalAllOnes
		:
		IInvertible
		,
		real.matrix_.dent_.IEchelon /// but the pivot might be away from diagonal
	{
	}
}
