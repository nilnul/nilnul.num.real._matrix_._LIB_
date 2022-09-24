using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square.be_
{
	public class DimThree
		: square.BeI1
	{
		public bool be(Square2 obj)
		{
			return obj.val.GetLength(0) == 3;
			//throw new NotImplementedException();
		}

		public class En : be.En_Rx<DimThree>
		{
			public En(Square2 v) : base(v)
			{
			}
		}


	}
}
