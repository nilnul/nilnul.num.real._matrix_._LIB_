using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.square
{
	/// <summary>
	/// matrix's eigen is a data structure of
	///		:
	///		a matrix
	///		,
	///		a value
	///		,
	///		a vector
	///			that is nonnil
	///	such that:
	///	
	/// for A
	///		if we can find v and lambda such that:
	///			Av=lambdaV
	///		then
	///			lambdaV is called eigen value and eigen vector. and together the co is called eigen
	///
	/// a matrix might have many eigens
	///		and for some eigens, they share same value, but with different vector.
	/// 
	/// </summary>
	/// alias:
	///		eig
    public interface IEigen
    {

    }
}
