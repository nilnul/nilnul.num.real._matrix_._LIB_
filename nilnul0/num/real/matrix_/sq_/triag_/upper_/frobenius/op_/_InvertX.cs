using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.triag_.upper_.frobenius.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="real.matrix_.sq_.gauss.op_._InvertX"/>
	/// <see cref="real.matrix_.sq_.basic_.skews_.slant.op_.IInvert"/>
	static public class _InvertX
	{
		static public void _Invert_1col(
			ref Q[,] matrix
			,
			int col
		)
		{

			for (int i = 0; i < col; i++)
			{
				matrix[i, col] = -matrix[i, col];
			}
		}
		static public Q[,] _Invert_1col(
			 Q[,] matrix
			,
			int col
		)
		{

			var cloned = (Q[,]) matrix.Clone();
			_Invert_1col(ref cloned, col);
			return cloned;
		}


	}
}
