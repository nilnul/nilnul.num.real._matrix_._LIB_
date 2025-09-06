using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R3 = nilnul.num.RealI;

namespace nilnul.num.real.matrix.vow.ee_
{
	public class VowDefault< TVow>
		:
		Ee
		where TVow : nilnul.obj.VowI2<R3[,]>, new()
	{
		public VowDefault(R3[,] val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
				)
		{
		}
	}
}
