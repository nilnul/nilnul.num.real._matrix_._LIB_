using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;



namespace nilnul.num.real.matrix_
{
	public class Square2
		: nilnul.num.real.matrix.be_.Square1.En
	{
		public Square2(R2[,] v) : base(v)
		{


		}

		public Square2(R[,] v) : base(v)
		{


		}
		public Square2(params int[] args) : this(
			args.Select(x => new nilnul.num.real_.Quotient(x))
			)
		{

		}

		public Square2() : base(new R2[0, 0])
		{

		}
		public Square2(IEnumerable<R2> args) : base(args)
		{


		}

		public Square2(IEnumerable<R> args) : base(args.Select(x=> new R2(x)))
		{


		}


		public Square2(params R2[] args) : base(args)
		{


		}


	}
}
