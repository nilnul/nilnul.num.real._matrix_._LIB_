using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix
{
	public class Eq4int
		:nilnul.obj.matrix.eq_.ElEqDefault<
			int, nilnul.num.integer_.int32.Eq
		>
	{


		static public Eq4int Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Eq4int>.Instance;
			}
		}
		static public Eq4int Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq4int>.Instance;
			}
		}



	}
}
