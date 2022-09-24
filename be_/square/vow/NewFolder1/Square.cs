using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using RI = nilnul.num.RealI;
using R = nilnul.num.Real;



namespace nilnul.num.real.matrix.be_
{

	public partial class Square1 

	{

	
		[Obsolete()]
		public class En : be.En1<Square1>
		{
			public En(R[,] v) : base(v)
			{
			}
	public En(RI[,] v) : base(v)
			{
			}
			public En(params R[] args):base(args)
			{

			}
	public En(IEnumerable< R> args):base(args)
			{

			}
		}

		 


	}
}
