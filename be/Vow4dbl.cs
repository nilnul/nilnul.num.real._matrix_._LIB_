using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R3 = System.Double;


namespace nilnul.num.real.matrix.be
{
	public class Vow4dbl
						:
						nilnul.obj.be.Vow4<System.Double[,]>
	{
		public Vow4dbl(BeI1<System.Double[,]> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<System.Double[,]> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<System.Double[,], bool> func) : base(func)
		{
		}
	}
}
