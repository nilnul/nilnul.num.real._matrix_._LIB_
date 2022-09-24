using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix
{
	public class Eq4dbl
		:nilnul.obj.matrix.eq_.ElEqDefault<
			double, nilnul.num.real.EqDbl
		>
	{

		static public Eq4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq4dbl>.Instance;
			}
		}

	}
}
