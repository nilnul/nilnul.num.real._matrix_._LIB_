using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.expr_
{
	/// <summary>
	/// 
	/// one of:
	///		<see cref="real.matrix.op_.IScale"/>
	///		<see cref="real.matrix.op_.INegate"/>
	///	, and:
	///		<see cref="real.matrix.bi_._AddX"/>
	///		<see cref="real.matrix.bi_._SubtractX"/>
	///		<see cref="real.matrix.bi_._MultiX"/>
	///	; 
	///	recursively.
	///	eg:
	///		3ABC-DDA +5
	///		,where D is square, otherwise the result is exception.
	/// </summary>
	/// 

	public interface IPolynomial:real.matrix.IExpr
	{
	}
}
