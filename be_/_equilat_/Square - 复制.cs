using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using RI = nilnul.num.RealI;
using R3 = nilnul.num.Real;



namespace nilnul.num.real.matrix.be_
{
	[Obsolete()]
	public class Square : BeI

	{

		
		public bool be(num.RealI[,] obj)
		{
			return  nilnul.matrix.be_._SquareX.Square(obj);
			//throw new NotImplementedException();
		}

		public bool be(R3[,] obj) {
			return nilnul.matrix.be_._SquareX.Square(obj);
		}


		static public Square Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Square>.Unison;
			}
		}


		public class En : be.En<Square>
		{
			public En(num.RealI[,] v) : base(v)
			{
			}
			public En(params RI[] args):base(args)
			{

			}
	public En(IEnumerable< RI> args):base(args)
			{

			}		}

	}
}
