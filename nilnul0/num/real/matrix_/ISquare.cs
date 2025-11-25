using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		equilat
	///		,
	///		square, which is a geometric shape. And we shall rename x^2 as not square, but something like selfMul, pow2nd, etc
	public interface ISquare
		:IMatrix
		,
		nilnul.obj.matrix_.ISquare
	{
	}


}
