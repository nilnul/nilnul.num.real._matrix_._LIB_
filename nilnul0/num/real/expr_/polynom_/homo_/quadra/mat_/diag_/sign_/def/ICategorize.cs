using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom_.homo_.quadra.mat_.diag_.sign_.def
{
	/// this is not trich/sign, as this is about the members of the set, some of which can be positive/negative/nil, while others can be triched otherwise.
	/// 
	/// <summary>
	/// for a vec:x,
	///		given a matrix A
	///			then let x=> x^T * A *x
	///				we use f to denote this func
	///		f(x) is nil if x is nil
	///		if x is nonnil, let's observe the value of f(x).
	///
	/// 
	/// then A is:
	///		indefinite
	///			if f(x) can be positive and negative
	///		definite:
	///		positive definite if
	///			if f(x) is always positive for nonnil x,
	///		negative definite
	///			if f(x) is always negative
	///		positive semidefinite/ nonneg definite
	///			if f(x) is always noneg
	///		negative semidefinite
	///			if f(x) is always nonpositive.
	///
	/// ;
	/// 	all nils are definite: zero, which is unpositive and unnegative.
	/// </summary>
	/// <see cref="real.expr_.polynom_.homo_.IQuadratic"/>
	public interface ICategorize
		: nilnul.obj.categorize_.ITrichotomy
	{
	}
}
