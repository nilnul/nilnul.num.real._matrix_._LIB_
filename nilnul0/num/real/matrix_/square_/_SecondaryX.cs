using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R2 = nilnul.num.Real;

namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// aka: 2x2
	/// </summary>
	static public class _SecondaryX
	{
		
	
		static public R Determinant(R a, R b, R c, R d ) {

			return square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
				new double[,] { { a, b }, { c, d } }
			) ;
		}
		static public R[,] Of(R a, R b, R c, R d ) {

			return 		new double[,] { { a, b }, { c, d } }
			;
		}

		static public double[,] OfCols4Dbl( (double a, double b) x, (double  c, double  d) y ) {

			return 		new double[,] { { x.a, y.c }, {x.b, y.d } }
			;
		}

		static public double[,] OfCols4Dbl( double a, double b, double  c, double  d ) {

			return 	new double[,] { { a, c }, { b, d } }
			;
		}




	}
}
