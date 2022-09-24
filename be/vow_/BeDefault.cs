using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


namespace nilnul.num.real.matrix.be.vow_
{
	public class BeDefault<TBe>
		: Vow
		where TBe : nilnul.obj.BeI1<R[,]>,new()
	{
		public BeDefault() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}

		
	}
}
