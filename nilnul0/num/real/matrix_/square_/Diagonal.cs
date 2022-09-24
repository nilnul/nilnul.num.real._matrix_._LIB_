using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// under as well as above the diagonal line are all nils
	/// </summary>
	public interface IDiagonal
		:
		triangular_.ILower
		,
		triangular_.IUpper
		//,
		//ITriangular
	{
	}
}
