using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square.be
{
	public class Anto4dbl
		:
		nilnul.obj.be.Anto<
			Square4dbl
		>
		,
		square.Be4dblI
	{
		public Anto4dbl(nilnul.obj.BeI1<Square4dbl> be) : base(be)
		{
		}
	}
}
