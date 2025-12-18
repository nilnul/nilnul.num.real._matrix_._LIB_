using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.toeplitz_
{

	/// <summary>
	/// all rows are composed of the same elements and each row is rotated one element to the right relative to the preceding row.
	/// it's also symmetric.
	/// </summary>
	/// <remarks>
	/// alternatively
	/// , a circulant matrix can be defined by specifying its first column rather than its first row of elements. In this case, each column is rotated one element down relative to the preceding column. 
	/// , and possibly with a different direction of shift (which is sometimes called an anti-circulant matrix).
	/// </remarks>
	public interface ICirculant
		: real.matrix_.sq_.IToeplitz
	{
	}
}
