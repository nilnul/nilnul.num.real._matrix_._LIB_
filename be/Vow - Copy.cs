using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;


namespace nilnul.num.real.matrix.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<R[,]>
	{
		public Vow4dbl(BeI1<R[,]> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<R[,]> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<R[,], bool> func) : base(func)
		{
		}
	}
}
