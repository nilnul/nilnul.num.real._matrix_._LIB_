using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using R = nilnul.num.RealI;


namespace nilnul.num.real.matrix.be
{
	public class Vow8quotient
						:
						nilnul.obj.be.Vow_ofIn<Q[,]>
	{
		public Vow8quotient(in BeI_ofIn<Q4[,]> val) : base(val)
		{
		}

		public Vow8quotient(BeI_ofIn<Q4[,]> x) : this(in x)
		{
		}
	}
}
