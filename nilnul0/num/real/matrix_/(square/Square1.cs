using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R3 = nilnul.num.RealI;

namespace nilnul.num.real.matrix_
{
	[Obsolete()]
	public class Square1
		: nilnul.num.real.matrix.be_.Square.En
	{
		public Square1(R3[,] v) : base(v)
		{


		}

		public Square1(params int[] args) : this(
			args.Select(x => new nilnul.num.real_.Quotient(x))
			)
		{

		}

		public Square1() : base(new R3[0, 0])
		{

		}
		public Square1(IEnumerable<R3> args) : base(args)
		{


		}
		public Square1(params R3[] args) : base(args)
		{


		}


	}
}
