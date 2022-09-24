using nilnul.num.real.matrix.square;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
 
using nilnul.num.real.matrix;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;



namespace nilnul.num.real.matrix_.square.aggregate_
{
	[Obsolete(nameof(matrix_.square.to_.scalar_._DeterminantX))]
	public static class _DeterminantX
	{
		static public R Determinant(
			nilnul.num.real.matrix_.Square1 square
			) {
			if (square.dimension.beZero)
			{
				return new Qr( 1);

			}
			R r =  new Qr(0);
			for (int i = 0; checked( (uint)i) < square.dimension.cols; i++)
			{
				
					r = nilnul.num.real.op_.binary_.Add.Singleton.op(r, nilnul.num.real.op_.binary_.Multi.Singleton.op( square.val[0, i] , Cofactor.Eval(square , 0, i))
						)
					;
			}
				return r;
			
		}

		static public R2 Determinant(
			nilnul.num.real.matrix_.Square2 square
			) {
			if (square.dimension.beZero)
			{
				return new Qr( 1);

			}
			R r =  new Qr(0);
			for (int i = 0; checked( (uint)i) < square.dimension.cols; i++)
			{
				
					r = nilnul.num.real.op_.binary_.Add.Singleton.op(r, nilnul.num.real.op_.binary_.Multi.Singleton.op( square.val[0, i] , Cofactor.Eval(square , 0, i))
						)
					;
			}
				return new R2( r);
			
		}

		
 	}//class
}
