using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.str.surrogate_
{
	/// Ax =b
	/// ,where x is the combinator, A holds the vecs as columns;
	/// ; 
	/// [a1,a2,...a[n] ] * [x1,x2,...,x[n]]
	///		, the inner product, or sum of product.
	///	sum of scaled:<see cref="num.real.vec.op_._ScaleX"/>
	/// <summary>
	/// coef is 0 or not zero..
	/// a trivia one is when all coefs are nil.
	/// </summary>
	/// <remarks>
	/// note:
	///		empty vecs summed is linear combination, and the result is 0 vector. Hence 0 vector is a linear combination of an empty set of vecs.
	///
	/// </remarks>
	///
	///  alias:
	///		scaled sum
	///		weighted sum.
	///		sum of scaled
	///		sum of weight
	///		colinearate
	/// <see cref="num.real.matrix.rows.ISpan"/> or <see cref="real.matrix.cols.ILinearCombinate"/>
	/// ;
	/// 
    public interface ILinearCombinate
		:
		vec.str.ISurrogate
		//real.vec.str._SumX
	{
    }
}
