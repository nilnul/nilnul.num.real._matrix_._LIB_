using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.square.cel.remnant.minor
{
	/// <summary>
	/// signed minor
	/// 代数余子式
	/// </summary>
	static public class _CofactorX
	{
		static public double _AssumeValid(double[,] matrix,int row,int col) {
			return nilnul.num.integer.op_.unary_.polyn._BaseNegOneX.OfNegOneAsInt
				//.int_.MinusOnePow.Eval
				(row + col)  // this is also called :Levi-Civita symbol
				* _MinorX._AssumeValid(matrix,row,col);
		
		}
	}
}
