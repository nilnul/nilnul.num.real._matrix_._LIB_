using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R3 = nilnul.num.RealI;

namespace nilnul.num.real.matrix.be
{
	//extern alias num;
	public class En<TBe>
		: nilnul.be.Asserted<R3[,], TBe>
		where TBe : BeI, new()
	{
		public En(R3[,] v) : base(v)
		{

		}
		public En(params R3[] args) : base(
			nilnul.matrix_.square.fro_._StrX.Eval<R3>(args).avowed
		)
		{

		}

		public En(IEnumerable<R3> args) : base(
				nilnul.matrix_.square.fro_._StrX.Eval<R3>(args).avowed
			)
		{

		}
		public override string ToString()
		{
			return nilnul.slew_.matrix.to_.Txt.Eval(val);
		}

		public nilnul.obj.matrix._dim.Ret dimension
		{
			get
			{
				return nilnul.obj.matrix._DimX.Dimension(val);
			}
		}

	}
}
