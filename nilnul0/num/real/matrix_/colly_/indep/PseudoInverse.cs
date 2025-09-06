//using nilnul.num.real.matrix;
using nilnul.num.real.matrix.bi_;
using nilnul.num.real.matrix_.sq_.invertible.op_;
using nilnul.obj.matrix.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.colly_.indep
{
    static public class _PseudoInverseX
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">
		/// colly independent matrix.
		/// </param>
		/// <returns>
		/// of size [cols, rows  ];
		/// the left inverse. that is, let y be the returned, then
		/// xy = I[cols, cols]
		/// </returns>
		static public double[,] _PseudoInverse_0collyIndep(double[,] x) {
			var transposed = x.Transpose();

			return transposed._Multiply_1sociable(
				x)._Inverse_0invertible()._Multiply_1sociable(
					transposed
				
			);
		}
    }
}
