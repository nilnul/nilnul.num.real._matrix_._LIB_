using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_
{
	/// <see cref="matrix.be_.IVacant"/>
	/// <summary>
	/// m*n = 0, where m is rows, n is cols;
	/// </summary>
	/// <remarks>
	/// this shall be taken seriously, in theory, and in practice it will make calculation algorithm deduction simple and straight. <see cref="real.matrix.equat_.linear.ISolve"/>
	/// </remarks>
	/// alias:
	///		empty, as matrix can be regarded as vect/str;
	///		hollow, only shell, no content
	///		shallow
	///		
	public interface IVacant
		:IMatrix
		,
		nilnul.obj.matrix_.IVacant
    {
    }




	




}
