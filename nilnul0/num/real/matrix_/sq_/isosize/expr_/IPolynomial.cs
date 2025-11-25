using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.isosize.expr_
{
	/// <summary>
	/// 
	/// one of:
	///		<see cref="real.matrix.op_.IScale"/>
	///		<see cref="real.matrix.op_.INegate"/>
	///		<see cref="real.matrix_.sq.op_.IPonent"/>
	///	, and:
	///		<see cref="real.matrix.bi_._AddX"/>
	///		<see cref="real.matrix.bi_._SubtractX"/>
	///		<see cref="real.matrix.bi_._MultiX"/>
	///	; 
	///	recursively.
	/// </summary>
	/// <see cref="sq.fn_"/>
	public interface IPolynomial:sq.IExpr
	{
	}
}
