using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using R = nilnul.num.RealI;


namespace nilnul.num.real.matrix.be
{
	public class Vow
						:
						nilnul.obj.be.Vow4<nilnul.num.RealI[,]>
	{
		public Vow(BeI1<nilnul.num.RealI[,]> be) : base(be)
		{
		}

		public Vow(Predicate<nilnul.num.RealI[,]> predicate) : base(predicate)
		{
		}

		public Vow(Func<nilnul.num.RealI[,], bool> func) : base(func)
		{
		}
	}
}
