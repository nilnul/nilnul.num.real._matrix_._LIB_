using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


namespace nilnul.num.real.matrix.be
{
	public class Vow
		:
		nilnul.obj.be.Vow4<R[,]>
	{
		public Vow(BeI1<R[,]> be) : base(be)
		{
		}

		public Vow(Predicate<R[,]> predicate) : base(predicate)
		{
		}

		public Vow(Func<R[,], bool> func) : base(func)
		{
		}
	}
}
