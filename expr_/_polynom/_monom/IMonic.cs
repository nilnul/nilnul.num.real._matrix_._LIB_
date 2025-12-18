using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.expr_._polynom._monom
{
	/// <see cref="num.real.expr_._polynom._monom.IMonic"/>
	/// <summary>
	/// eg:
	///		 x^2
	///		 x^0 =1
	///		 xyz^2
	///	;exclude:
	///		3x^2
	///			,where 3 is not 1
	///		2 = 2*x^0
	///			,where 2 is not 1
	///		
	///		
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// alias:
	///		product, without scale
	///		unscale
	///		minterm
	///			,as in boolean algebra
	/// 
	internal class IMonic
	{
	}
}
