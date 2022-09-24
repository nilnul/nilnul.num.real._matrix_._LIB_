using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.square
{
	/// <summary>
	/// signed minor
	/// </summary>
	///
	[Obsolete(nameof(num.real.matrix_.square.cel.remnant.minor._CofactorX) )]
	public  class Cofactor
	{
		static public double Eval(double[,] matrix,int row,int col) {
			return nilnul.num.int_.MinusOnePow.Eval(row + col)*Minor.Eval(matrix,row,col);
		
		}
	}
}
