using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_
{
	/// <summary>
	/// when a matrix is initialized, it's already all nils.
	/// </summary>
	static  class _DefaultedX
	{
		static public double[,] Generate(int x,int y) {
			return new double[x, y];
		}

	} 
}
