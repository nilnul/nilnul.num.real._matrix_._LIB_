using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.vow.ee_
{
	public class VowDefault4Dbl< TVow>
		:
		Ee4dbl
		where TVow : nilnul.obj.VowI2<double[,]>, new()
	{
		public VowDefault4Dbl(double[,] val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
				)
		{
		}
	}
}
