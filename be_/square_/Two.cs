using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_.square
{
	public class Two : BeI
	{
		public bool be(num.RealI[,] obj)
		{
			return num.real.matrix.be_.Square1.Singleton.be(obj) && obj.GetLength(0) == 2;
			//throw new NotImplementedException();
		}


	}
}
