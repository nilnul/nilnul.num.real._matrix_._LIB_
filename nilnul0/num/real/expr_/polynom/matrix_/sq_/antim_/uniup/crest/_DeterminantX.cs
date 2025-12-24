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
using P = nilnul.num.real.expr_.Algebraic;
using System.Diagnostics.Contracts;



namespace nilnul.num.real.expr_.polynom.matrix_.sq_.antim_.uniup.crest
{
	static public class _DeterminantX
	{
		static public real.expr_.Algebraic _Determinant_1uniabs(
			int wide, num.real.expr_.Var1 a, num.real.expr_.Var1 x
		)
		{

#if DEBUG


			/// determinant of
			/// [
			///		x,	a,	a,	a,	a
			///		-a,	x,	a,	a,	a
			///		-a,	-a,	x,	a,	a
			///		-a,	-a,	-a,	x,	a
			///		-a,	-a,	-a,	-a,	x
			/// ]
			/// 



			/// each row minus the next row:
			/// 

			var m = antim_.uniup._CrestX.Generate(wide, a, x);

			var freezed = (Algebraic[,])m.Clone();


			for (int i = 0; i<wide-1; i++)
			{
				for (int j = 0; j<wide; j++)
				{
					m[i, j] -= m[i+1, j];
				}
			}

			/// ,
			/// [
			///		x+a,	a-x,	0,		0,		0
			///		0,		x+a,	a-x,	0,		0
			///		0,		0,		x+a,	a-x,	0
			///		0,		0,		0,		x+a,	a-x
			///		-a,		-a,		-a,		-a,		x
			/// ]
			/// 


			/// each column minus previous one
			for (int c = wide-1; c>0; c--)
			{
				for (int r = 0; r<wide; r++)
				{
					m[r, c] -= m[r, c-1];
				}
			}

			/// [
			///		x+a,	-2x,		x-a,		0,			0
			///		0,		x+a,		-2x,		x-a,		0
			///		0,		0,			x+a,		-2x,		x-a
			///		0,		0,			0,			x+a,		-2x
			///		-a,		0,			0,			0,			x+a
			/// ]
			/// 

			nilnul.num.real.expr_.polynom._MatrixX.Simplify(ref m);

			if (wide>0)
			{
				Contract.Assert(
					m[wide-1, 0] == freezed[wide-1, 0]
				);

				num.real.expr_.polynom.matrix_.sq.be_.toeplitz._VowX._Vow_0sq(in m);

				var cloned = (P[,])m.Clone();

				cloned[wide-1, 0] =0;

				num.real.expr_.polynom.matrix_.sq.be_.triag_.upp._VowX._Vow_0sq(in cloned);

				for (int c = 3; c<wide; c++)
				{
					Contract.Assert(
						m[0, c] == 0
					);
				}
			}

			/// laplace expansion along the last row:
			/// 
			/// -a (-1)^(n-1) * det of <see cref="real.matrix_.sq_.tridiag_.toeplitz._DeterminantX"/> of M(n-1) + (x+a)^n
			/// 
			///  discriminant of M:
			///		(-2x)^2 - 4 *(x-a)(x+a)
			///		4 x^2 -4 *(x-a)(x+a) 
			///		= 4a^2
			///		sqrtDiscriminant = 2a
			///		
			///	when a !=0, 
			/// the determinant of M(n-1):
			///		
			///		((-2x +2a)/2 ) ** (n) - (-2x -2a)/2  ** (n)
			///		/
			///		2a
			/// =
			///		(a-x)^n - (-a-x)^n
			///		/
			///		2a
			///		
			/// so, the original matrix's determinant is:
			/// 
			/// (-a) *(-1)^(n-1) * ( (a-x)^n - (-a -x)^n ) / 2a + (x+a)^n
			/// =(x+a)^n + (-a) *(-1)^(n-1) * (-1)^(n+1)  (x+a)^n /2a  - a *(-1)^(n-1)  (a -x)^n /2a
			/// =(x+a)^n -a *  (x+a)^n /2a - a *(-1)^(n-1)  (a -x)^n /2a
			/// 
			/// =(x+a)^n /2  - (-1)^(n-1) *(-1)^n  (x-a)^n /2
			/// =(x+a)^n /2  +  (x-a)^n/2
			///  
			/// ,when n=1,
			///		(x+a)/2 + (x-a)/2
			///		= x
			///	;when n=2,
			///	x^2 +a^2

			/// the result is not lower triangular, as the row0 is not changed.
			/// 
			//nilnul.num.real.expr_.polynom.matrix_.sq.be_.triag_.low._VowX._Vow_0sq(m);


			/// alternatively, let's try recurrence directly on the original matrix.
			/// 
			/// determinant of
			/// 
			/// [
			///		x,	a
			///		-a,	x
			/// ]
			///		= x^2 +a^2
			///		
			/// 
			/// [
			///		x,	a,	a
			///		-a,	x,	a
			///		-a,	-a,	x
			/// ]
			/// = x*(x^2 + a^2) - a*(-a*x + a^2)    + a*(-a* -a + a*x)
			/// = x^3 +a^2 x  + a^2 x -aaa  +aaa +aax
			/// =xxx +3aax
			/// =2\((x-a)**3 + (x+a)**3)
			///		,where all a**(2n+1) would be cancelled out 
			/// 
			/// 

#endif
			return (
				num.real.expr_.polynom.calc.op_._PonentX._Pon_0num(x+ a, wide)
				+ 
				num.real.expr_.polynom.calc.op_._PonentX._Pon_0num(
					new P(x) - a
					,
					wide
				)
			)
			/2
			;

			//return wide switch
			//{
			//	0 => 1
			//	,
			//	1 => x  /// freezed[0, 0]
			//	,
			//	_ => (num.real.expr_.polynom.calc.op_._PonentX._Pon_0num(x+ a, wide)

			//		+ num.real.expr_.polynom.calc.op_._PonentX._Pon_0num(
			//			new P(x) - a
			//			,
			//			wide
			//		)
			//	)
			//	/2
			//};

		}
	}
}
