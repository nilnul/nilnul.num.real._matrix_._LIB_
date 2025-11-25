using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.grid_.plaid.be_
{
	/// <summary>
	/// there is a blok at the diagonal (as this is a <see cref="IPlaid"/>), the wideth of which is greathan half the wideth of the matrix.
	/// 
	/// eg:
	///		[	
	///			a00,a01,a02,a03,a04
	///			a10,a11,a12,a13,a14
	///			0,	0,	0,	a23, a24
	///			0,	0,	0,	a33, a34
	///			0,	0,	0,	a43, a44
	///		
	///		]
	///	;
	///	the determ would be 0;
	///	
	/// </summary>
	internal class NilBlocWiderThanHalf
	{
	}
}
