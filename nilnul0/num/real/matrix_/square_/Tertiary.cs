using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RI = nilnul.num.RealI;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R2 = nilnul.num.Real;

namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// for real numbers
	/// </summary>
	public class Tertiary
		:nilnul.num.real.matrix_.square.be_.DimThree.En
		,
		ITertiary
	{
		

		public Tertiary(Square2 s):base(s)
		{

		}

		public Tertiary(RI[,] array):this(new Square2(array))
		{


		}

		public Tertiary(R2[,] array):this(new Square2(array))
		{


		}
		public Tertiary(RI a, RI a1, RI a2, RI b,RI b1, RI b2, RI c, RI c1, RI c2) : this(
			new Square2( new[,] { { a, a1,a2 }, { b,b1,b2 }, { c,c1,c2} } )	
		)
		{

		}

		public Tertiary(R2 a, R2 a1, R2 a2, R2 b,R2 b1, R2 b2, R2 c, R2 c1, R2 c2) : this(
			new Square2( new[,] { { a, a1,a2 }, { b,b1,b2 }, { c,c1,c2} } )	
		)
		{

		}


		public Tertiary(int v1, int v2, int v3, int v4, int v5,int v6,int v7, int v8,int v9)
			:this(
				 new nilnul.num.real_.Quotient(v1)
				 ,
				 new nilnul.num.real_.Quotient(v2)
				 ,new nilnul.num.real_.Quotient(v3)


				 ,new nilnul.num.real_.Quotient(v4)
				 ,
				 new nilnul.num.real_.Quotient(v5)
				 ,new nilnul.num.real_.Quotient(v6)


				 ,new nilnul.num.real_.Quotient(v7)

				 ,
				 new nilnul.num.real_.Quotient(v8)
				 ,new nilnul.num.real_.Quotient(v9)

			)
		{
			
		}



		 

		static public Tertiary operator *(Tertiary x, Tertiary y) {
			return new Tertiary(
				nilnul.num.real.matrix.duo_.sociable.Multi.Multiply(x, y)
				);
		}

		static public implicit operator RI[,] (Tertiary x) {
			return x.val.val;
		}


		static public implicit operator R2[,] (Tertiary x) {
			return nilnul.slew_.matrix.op_._CastX.Cast<RI,R2>(
				(RI[,])x, y=>new R2(y));
		}

		static public implicit operator Square2 (Tertiary x) {
			return new Square2(x);
		}

	}
}
