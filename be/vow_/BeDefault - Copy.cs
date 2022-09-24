using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;


namespace nilnul.num.real.matrix.be.vow_
{
	public class BeDefault4Dbl<TBe>
		: Vow4dbl
		where TBe : nilnul.obj.BeI1<R[,]>,new()
	{
		public BeDefault4Dbl() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}

		
	}
}
