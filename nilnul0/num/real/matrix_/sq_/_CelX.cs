using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R3 = System.Double;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R2 = nilnul.num.Real;

namespace nilnul.num.real.matrix_.sq_
{
	/// <summary>
	/// aka: 1x1
	/// </summary>
	static public class _CelX
	{
	
		//static public R3 Determinant(R3 a ) {
		//	return a ;
		//}
		//static public Q Determinant(Q a ) {
		//	return a ;
		//}

		/// <summary>
		/// row major. one row first, then the other row;
		/// </summary>
		/// <param name="a">row0</param>
		/// <param name="b">row1</param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <returns></returns>
		/// 

		static public R3[,] Of(R3 a ) {
			return new double[,] { { a } };
		}

		static public Q[,] Of(Q a ) {
			return new Q[,] { { a } };
		}

	}
}