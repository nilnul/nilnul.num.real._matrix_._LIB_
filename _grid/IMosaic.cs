using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix._grid
{
	/// <summary>
	/// a matrix of matrix.
	/// the inner matrix is called block.
	/// block can be empty.
	/// block can vary in size.
	/// mosaic may or may not be the partition of a matrix. some mosaic cannot be converted to matrix.
	/// 
	/// </summary>
	public interface IMosaic
		:obj.matrix._grid.IMosaic
	{
	}
}
