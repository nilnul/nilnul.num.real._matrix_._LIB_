using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square.be_
{
	public class Two
		: square.BeI
	{
		public bool be(Square1 obj)
		{
			return obj.val.GetLength(0) == 2;
			//throw new NotImplementedException();
		}
	}
}
