using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.seq;
using nilnul.slew_;
using nilnul.obj;

namespace nilnul.num.ieee.matrix.str.be_
{
	public class StartedProductable : BeI
	{
		
		public bool be(IEnumerable<double[,]> obj)
		{
			return nilnul.matrix.str.be_.StartedProductable<double>.Singleton.be(obj);

			//throw new NotImplementedException();
		}

		public class En : nilnul.be.Asserted_assertDefaultDiscarded<IEnumerable<double[,]>, StartedProductable>
		{
			public En(IEnumerable<double[,]> val) : base(val)
			{
			}
		}




	}
}
