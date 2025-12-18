using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.num.real.expr_._algebraic;
using nilnul.obj.stream_.slider.to_;
using nilnul.num.real.expr_.polynom.matrix_.sq;
using nilnul.obj.str;
using nilnul.num.real.expr_;
using System.Numerics;


namespace nilnul.num.real.matrix_.sq_.sym_.hankel_.circulant_.positional
{
	static public class _DeterminantX
	{
		static public BigInteger _ToDeterminant_0wide(int n)
		{

			///define the matrix



			/// []
			/// 
			/// [1]
			/// [
			///		1, 2
			///		2, 1
			/// ]
			/// [
			///		1,2,3
			///		2,3,1
			///		3,1,2
			/// 
			/// ]
			/// 
			/// [
			///		1,2,3,4
			///		2,3,4,1
			///		3,4,1,3
			///		4,1,2,3
			/// ]
			/// 



			/// [
			///		1,2,3,4,5
			///		2,3,4,5,1
			///		3,4,5,1,2
			///		4,5,1,2,3
			///		5,1,2,3,4
			/// ]
			/// 
			///  add cols to col0:
			///  
			/// [
			///		15,2,3,4,5
			///		15,3,4,5,1
			///		15,4,5,1,2
			///		15,5,1,2,3
			///		15,1,2,3,4
			///		
			/// ]
			/// 
			/// subtract row0:
			/// 
			/// [
			///		15,2,3,4,5
			///		0,1,1,1,-4
			///		0,2,2,-3,-3
			///		0,3,-2,-2,-2
			///		0,-1,-1,-1,-1
			/// ]
			/// 
			/// [
			///		15,2,3,4,5
			///		0,0,0,0,-4-1
			///		0,0,0,-3-2,-3-2
			///		0,0,-2-3,-2-3,-2-3
			///		0,-1,-1,-1,-1
			/// ]
			/// => n(n+1) /2 * -5 * -5 * -5 * -1 * (-1) ^  (3+2+1)
			///  = n(n+1) /2 *  (-n)^(n-2)  * -1 * (-1) ^ ( (n-1)(n-2)/2)
			///  = n(n+1) /2 *  n^(n-2)  *  (-1)^( n-2 + 1 + (n-1)(n-2)/2)
			///  = n(n+1) /2 *  n^(n-2)  *  (-1)^( (n-1)(n-2)/2 + n-1)
			///  
			///  = n(n+1) /2 *  n^(n-2)  *  (-1)^( (n-1)n/2)
			///  = (n+1) /2 *  n^(n-1)  *  (-1)^( (n-1)n/2)

			/// eg:
			///		n=2 =>  3/2 * 2^1 * -1 = -3
			///		n=3 =>  4/2 * 3^2 * 1 = 18
			///		n=4 =>  5/2 * 4^3 * -1 = -160
			///		n=5 =>  6/2 * 5^4 * 1 = 1875





			var algebraic = (n+1) * BigInteger.Pow(n, n - 1) 
				/ 2 
				*
				nilnul.num.integer_.unial.of_.cast_._NegOneIndicX.NegOneIndic(
					(n - 1) * n / 2 
				)  ///  % 2 == 0 ? 1 : -1
				
			;
			return algebraic;






		}





	}
}
