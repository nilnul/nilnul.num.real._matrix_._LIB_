using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_
{
	/// <summary>
	/// the matrix is trichotomized into three parts:
	///		the two triangles, and the parallelogram formed by the two main diagonals(one from the upper left corner, the other from the lower right corner);
	///		barring the lower triangular, the upper part(including the parallelogram, and the upper triangular) is called upper trapezoidal;
	///		barring the upper triangular, the lower part(including the parallelogram, and the lower triangular) is called lower trapezoidal;
	///		
	/// </summary>
	/// alias:
	///		trapezoidal
	///			trape, same count of letters as <see cref="trape_"/>
	///		trapezoid;
	///			
	///			
	/// vs:
	///		<see cref="real.matrix_.ITriangular"/>
	public interface ITrapezoidal:real.IMatrix
	{
	}


}
