using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R2 = nilnul.num.Real;

namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// aka: 2x2
	/// </summary>
	/// alias:
	///		matrix2sq
	///		sq2
	///		sqTwo
	public class Secondary
		:nilnul.num.real.matrix_.square.be.En< square.be_.Two>
		,
		ISecondary
	{
		

		public Secondary(Square1 s):base(s)
		{

		}

		public Secondary(R[,] array):this(new Square1(array))
		{


		}

		public Secondary(R a, R b, R c, R d) : this(
			new Square1( new[,] { { a, b }, { c, d } } )	
		)
		{

		}

		public Secondary(int v1, int v2, int v3, int v4)
			:this(
				 new nilnul.num.real_.Quotient(v1)
				 ,
				 new nilnul.num.real_.Quotient(v2)
				 ,new nilnul.num.real_.Quotient(v3)
				 ,new nilnul.num.real_.Quotient(v4)
			)
		{
			
		}



		public R getDeterminant() {
			return square.Determinant.Eval_2x2(
				
				val.val[0,0]
				,val.val[0,1]
				,val.val[1,0]
				,val.val[1,1]
				
				);
		}
		static public R GetDeterminant(R a, R b, R c, R d ) {

			return a.Multi(d).Minus(
					b.Minus(c)
				);
		}

		static public Secondary operator *(Secondary x, Secondary y) {
			return new Secondary(
				nilnul.num.real.matrix.duo_.sociable.Multi.Multiply(x, y)
				);
		}

		static public implicit operator R[,] (Secondary x) {
			return x.val.val;
		}
		static public implicit operator R2[,] (Secondary x) {
			return nilnul.slew_.matrix.op_._CastX.Cast<R,R2>(
				(R[,])x, y=>new R2(y));
		}


	}
}
