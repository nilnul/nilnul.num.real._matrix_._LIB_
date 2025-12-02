using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix_.sq.op_
{
	/// <summary>
	/// a str of <see cref="op_.IBasic"/>
	/// </summary>
	/// alias:
	///		IInvertible
	///		vertible
	///			,where v can be used for such operation;
	///		
	public interface IVertible:sq.IOp
	{
	}

	/// <summary>
	/// find its inversal.
	/// throw if it's not <see cref="IVertible"/>;
	/// </summary>
	public interface IInvert:sq.IOp
	{
	}



}
