using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.isosize.fn_
{
	/// <see cref="matrix_.sq.of_."/>
	/// <summary>
	/// A =>
	///		a[0] + a[1] A + ... + a[n] A^n
	/// ,where A is <see cref="matrix_.sq"/>
	/// ,n is natural so A^n is <see cref="sq.op_.IPonent"/>
	/// , a[0] shall be cast as <see cref="sq_.IScaler"/>
	/// 
	///			
	/// </summary>
	/// <remarks>
	/// Sum of product
	///		,where the product is : <see cref="nilnul.num.real.expr_._polynom.IMonomial"/> but with <see cref="matrix_.sq"/> as the input.
	/// 
	/// </remarks>
	/// <see cref="sq.expr_.IPolynomial"/>
	public interface IPolynomial:sq.IFn
	{
	}
}
