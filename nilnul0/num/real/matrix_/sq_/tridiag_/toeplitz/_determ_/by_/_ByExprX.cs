using nilnul.num.quotient_._as_;
using nilnul.num.real.expr_;
using nilnul.num.real.expr_._algebraic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.tridiag_.toeplitz._determ_.by_
{
	///https://math.stackexchange.com/questions/266998/how-to-compute-the-determinant-of-a-tridiagonal-toeplitz-matrix
	/// <summary>
	/// by symbol calculation
	/// </summary>
	/// alias:
	///		_ByInductionX
	static public class _ByExprX
	{

		static public Q4 _Determinant_ofTridiagToeplitz(int wide, Q4 c00, Q4 c01, Q4 c10) {
			if (wide==0)
			{
				return (Q4)1;
			}
			if (wide==1)
			{
				return c00;
			}


			/// d[n] = c00 d[n-1] - c01 c10 d[n-2]:
			/// 
			int wPlus = (wide+1);
			var discrimant = c00 * c00 - 4 * c01 * c10;
			if (discrimant==0)
			{
				///

				return wPlus * nilnul.num.quotient.op_._PonentX._Quotient_1natural( 
					c00/2, wide
					) 
				;
				/// proof:
				/// d[n] = c00 * wide *  c00/2^(wide-1) -c01 c10 * (wide-1) * c00/2^(wide-2)
				///  = c00/2^(wide-2) ( wide * c00/2 *c00 - (wide-1) c01 c10)
				///  = c00/2^(wide-2) ( wide * c00*c00/2 - (wide-1) (c00*c00/4))
				///  = c00/2^(wide-2) ( (2* wide - wide +1) c00*c00/4)
				///  = c00/2^(wide-2) ( ( wide +1) c00*c00/4)
				///  = ( wide +1) (c00/2)^ wide
				///  
			}

			var 
				//sqrtDiscrimant 
				d
				= new nilnul.num.real.expr_.Var1(); /// actually, it's quotient

			Algebraic c00AsPolynom = new(
							new nilnul.num.real_.Quotient(
							new nilnul.num.Quotient1(c00._numerator, c00._denominator)
					));
			var numer =  
				nilnul.num.real.expr_.polynom.calc.op_._PonentX._Pon_0num( /// todo: to use quotient.expr_.polynom
					c00AsPolynom+d ///.AsPow()
					
					,
					wPlus
				)
				-
				nilnul.num.real.expr_.polynom.calc.op_._PonentX._Pon_0num(
					c00AsPolynom-d ///.AsPow()
					
					,
					wPlus
				)
				
			;


			numer.simplify(); 
							  /// change d^(2n) to (c00^2-4 c01 c10)^n
							  /// todo: this is not rigorous; to be rigorous, as the sqrt of that is not quotient, and in fact it's complex. we can use a complex polynom of quotient coefficients to make this more rigorous.
							  /// 
			numer = new Algebraic( numer.scaleds.Select(
				s => new real.expr_._algebraic.pows.prod.Scaled_powIndexPositive(
					new num.real.expr_._algebraic.pows.prod.Scaled(
	
					nilnul.num.real_.quotient_._as_._RegressionsX.ToRational(
						nilnul.num.quotient.op_._PonentX._Quotient_1natural(discrimant, s.degree /2)
						* 
						s.coef.current.lower.mark.ToQuotient()
					)
					,
					new expr_._algebraic.pows.Product(
						new real.expr_._algebraic.Pow ( 
							d, new nilnul.Num1( s.degree %2  )
						)
					)
				)
				))
				);
			numer.simplify(); /// would be: q d, as addend containing d^(2n) would be cancelled against each other
			/// 
			/// hence:
			///   c(n+1, 1)  d**1  a**n 2  
			///   +
			///   c(n+1,3) d**3 a**(n-2) 2
			///   +...
			///   c(n+1, n) d**n a**1 2
			///   =
			///   c(n+1, 1)  d**1  a**n 2  
			///   +
			///   c(n+1,3)  d**3 a**(n-2) 2
			///   +...
			///   c(n+1, n) d**n a**1 2
			///		# d**2 =0
			///		
			///   =
			///   c(n+1, 1)  d**1  a**n 2  
			///   = (n+1) d   a**n 2
			///		, which ,when divied by 2^(n+1) d
			///		= (n+1) a**n / 2**n
			/// 
			///   ; So even when discriminator is 0, the var:d here can still be safely cancelled.

			return nilnul.num.quotient_.denomNonnil._RegressionsX.ToDenomNonnil(
				numer.scaleds.First().coef.current.lower.mark
				) / (1<<wPlus);

			/// proof:
			/// d[n] = c00 * d(n-1)  -c01 c10 * d(n-2)
			///  = c00    ((c00+d)^wide - (c00 -d)^wide) / (2^ wide d)
			///   - c01 c10  ( (c00+d)^(wide-1) - (c00 -d)^(wide-1) ) / (2^ (wide-1) d)
			///  = (
			///		2c00    ((c00+d)^wide - (c00 -d)^wide)
			///		-  c01 c10  4( (c00+d)^(wide-1) - (c00 -d)^(wide-1) ) 
			///		)
			///		/ (2^ (wide+1) d)
			///  = 
			///  
			///  = (
			///		 (2 c00 (c00+d) -4 c01 c10)   (c00+d)^ (wide-1)   /// the c00+d) ^wide part
			///		- (
			///				2c00 (c00-d)^(wide-1) - 4 c01 c10  ( (c00-d)^(wide-1)
			///		)
			///		/ (2^ (wide+1) d)
			///		
			///  = (
			///		 (2 c00 (c00+d) -4 c01 c10)   (c00+d)^ (wide-1)   /// the c00+d) ^wide part
			///		- (
			///				2c00(c00-d) (c00-d)^(wide-1) - 4 c01 c10  ( (c00-d)^(wide-1)
			///		)
			///		/ (2^ (wide+1) d)
			/// 
			///  = (
			///		 (2 c00 (c00+d) -4 c01 c10)   (c00+d)^ (wide-1)   /// the c00+d) ^wide part
			///		- (
			///				(2 c00(c00-d)  - 4 c01 c10  )( (c00-d)^(wide-1)
			///		)
			///		/ (2^ (wide+1) d)
			///		
			///  = (
			///		 (2 c00 (c00+d) -4 c01 c10)   (c00+d)^ (wide-1)   /// the c00+d) ^wide part
			///		- (
			///				(2 c00(c00-d)  - 4 c01 c10  )( (c00-d)^(wide-1)
			///		)
			///		/ (2^ (wide+1) d)
			/// 
			///  = (
			///		 (2 c00 (c00+d) -4 c01 c10)   (c00+d)^ (wide-1)   /// the c00+d) ^wide part
			///		- (
			///				(2 c00(c00-d)  - 4 c01 c10  )
			///				/
			///				(c00-d)^2= c00*c00 -2c00d + c00*c00 -4 c01 c10
			///				(c00-d)^(wide+1)
			///		)
			///		/ (2^ (wide+1) d)
			/// 
			///  = (
			///		 (2 c00 (c00+d) -4 c01 c10) 
			///		 /
			///		 (c00+d)^2 = c00*c00 +2c00d + c00*c00 -4 c01 c10
			///		 *
			///		(c00+d)^ (wide+1) 
			///		
			///		- (
			///			(c00-d)^(wide+1)
			///		) 
			///	  )
			///		/ (2^ (wide+1) d)
			///		
			/// 
			///  = (
			///		 (2 c00 (c00+d) -4 c01 c10) 
			///		 /
			///		 (c00+d)^2 = c00*c00 +2c00d + c00*c00 -4 c01 c10
			///		 *
			///		(c00+d)^ (wide+1) 
			///		
			///		- (
			///			(c00-d)^(wide+1)
			///		) (c00 -d)^wide
			///	  )
			///		/ (2^ (wide+1) d)
			/// 
			///  = (
			///		 (2 c00 (c00+d) -4 c01 c10) 
			///		 /
			///		 (c00+d)^2 = c00*c00 +2c00d + c00*c00 -4 c01 c10
			///		 *
			///		(c00+d)^ (wide+1) 
			///		
			///		- (
			///			 (c00-d)^(wide+1)
			///		) 
			///	  )
			///		/ (2^ (wide+1) d)
			/// 
			/// 
			///  = (
			///		
			///		(c00+d)^ (wide+1) 
			///		
			///		- (
			///			 (c00-d)^(wide+1)
			///		) 
			///	  )
			///		/ (2^ (wide+1) d)
			///		
			/// 
			///  
		}
	}
}
