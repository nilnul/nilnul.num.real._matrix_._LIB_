using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R3 = nilnul.num.RealI;
using R2 = nilnul.num.Real;
using nilnul.num.real.matrix_.sq.aggregate_;



namespace nilnul.num.real.matrix_.sq
{
	/// <summary>
	/// signed minor
	/// </summary>
	///
	[Obsolete()]
	public partial class Cofactor
	{
		static public R3 Eval( Square1 matrix,int row,int col) {
			return nilnul.num.real.op_.binary_.Multi.Singleton.op(  nilnul.num.int_.MinusOnePow.Eval(row + col)
				
				,
				
				_MinorX.Minor(matrix,row,col)
				);
		
		}
		static public R2 Eval( Square2 matrix,int row,int col) {
			return new R2( nilnul.num.real.op_.binary_.Multi.Singleton.op(  nilnul.num.int_.MinusOnePow.Eval(row + col)
				
				,
				
				_MinorX.Minor(matrix,row,col)
				));
		
		}


	}
}
