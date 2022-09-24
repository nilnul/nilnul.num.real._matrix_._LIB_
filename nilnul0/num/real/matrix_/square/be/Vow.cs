using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square.be
{
	public class Vow4dbl
		:
		nilnul.obj.be.Vow4<
			Square4dbl
		>
		,square.Vow4dblI
	{
		public Vow4dbl(BeI1<Square4dbl> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Square4dbl> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Square4dbl, bool> func) : base(func)
		{
		}
	}
}
