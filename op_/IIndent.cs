using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_
{
	/// <see cref="num.real.matrix.be_.IIndent"/>
	///
	/// <summary>
	/// the result is echelon
	/// next row after the current row is indented at least one cel, where indention means 0 cels in the beginning.
	/// </summary>
	/// alias:
	///		indent
	///		gausian
	///		indent,inden
	///		
	///	vs:	Echelon
	///			,row echelon form
	///			,Some texts add the condition that the leading coefficient must be 1 ,  while others require this only in reduced row echelon form ()
	///		
	public interface IIndent
		:
		matrix.op_.IHull
		//,
		//matrix.IOp
	{
	}

}
