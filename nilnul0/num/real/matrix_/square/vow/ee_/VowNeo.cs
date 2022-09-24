using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square.vow.ee_
{
	public class VowNeo4Dbl<TVow>
		:
		vow.Ee4dbl
		where TVow: nilnul.obj.VowI2<
			Square4dbl
		>,new()
	{
		public VowNeo4Dbl(Square4dbl val) : base(val,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

			)
		{
		}
	}
}
