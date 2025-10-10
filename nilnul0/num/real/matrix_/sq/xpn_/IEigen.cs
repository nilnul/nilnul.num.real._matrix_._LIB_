using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.sq.xpn_
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
	/// <remarks>
	/// deferrable to complex matrix, as solving the polynomial might get complex number
	/// </remarks>
	///
	///
	/// 
	/// alias:
	///		eig
	///		
	[Obsolete("most matrix has eigen val unsolvable algebraically, and computatation results complex number as eigenval;(let's just image there is a complex element in the word eigen); hence see:nilnul.num.complex.matrix project, where we still can define nilnul.num.real.matrix_.sq.IEigen.")]
    public interface IEigen
    {

		/// ( A - aE ) V = a V
		/// , where a is the eigen value. 


	}




}
