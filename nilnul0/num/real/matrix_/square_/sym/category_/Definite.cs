using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.sym.category_
{
	/// <summary>
	/// for a vec:x,
	///		given a matrix A
	///			then let x=> x^T * A *x
	///				we use f to denote this func
	///		f(x) is nil if x is nil
	///		if x is nonnil, let's observe the value of f(x).
	/// then A is:
	///		positive definite if
	///			if f(x) is always positive for nonnil x,
	///		negative definite
	///			if f(x) is always negative
	///		positive semidefinite/ nonneg definite
	///			if f(x) is always noneg
	///		negative semidefinite
	///			if f(x) is always nonpositive.
	///		indefinite
	///			if f(x) can be positive and negative
	/// </summary>
	public interface IDefinite
		:nilnul.obj.categorize_.ITrichotomy
	{
	}
}
