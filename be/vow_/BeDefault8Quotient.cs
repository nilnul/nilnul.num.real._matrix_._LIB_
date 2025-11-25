using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R3 = System.Double;


namespace nilnul.num.real.matrix.be.vow_
{
	public class BeDefault8Quotient<TBe>
		: Vow8quotient
		where TBe : nilnul.obj.BeI_ofIn<Q[,]>,new()
	{
		public BeDefault8Quotient() : base(
			 nilnul._obj.typ_._UnisonX<TBe>.Unison
		)
		{
		}

		static public BeDefault8Quotient<TBe> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<BeDefault8Quotient<TBe>>.Unison;
			}
		}


	}
}
