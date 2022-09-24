using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix
{
	/// <summary>
	/// every element is real, and is known
	/// </summary>
	///
	[Obsolete()]
	public  interface MatrixI
	{
		int rowCount
		{
			get;
			set;
		}
		int colCount
		{
			get;
		}
		double item(int row,int col);
	}
}
